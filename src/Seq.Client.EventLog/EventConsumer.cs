using Serilog;
using Serilog.Events;
using Serilog.Parsing;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace Seq.Client.EventLog
{
    static class EventConsumer
    {
        public static void PostRawEvents(RawEvents rawEvents)
        {
            foreach(var rawEvent in rawEvents.Events)
            {
                Exception exception = null;
                if (!string.IsNullOrEmpty(rawEvent.Exception))
                {
                    exception = new Exception(rawEvent.Exception);
                }

                var template = new MessageTemplateParser().Parse(rawEvent.MessageTemplate);
                var properties = new List<LogEventProperty>();
                foreach(var prop in rawEvent.Properties)
                {
                    properties.Add(new LogEventProperty(prop.Key, new ScalarValue(prop.Value)));
                }
                
                properties.Add(new LogEventProperty("Timestamp", new ScalarValue(rawEvent.Timestamp)));

                var logEvent = new LogEvent(rawEvent.Timestamp, rawEvent.Level, exception, template, properties);

                Log.Logger.Write(logEvent);
            }
        }

        public static void PostEventRecord(EventRecord eventRecord)
        {
            var template = new MessageTemplateParser().Parse(eventRecord.TaskDisplayName ?? eventRecord.LogName);
            var datetimeOffset = DateTime.SpecifyKind(eventRecord.TimeCreated.Value, DateTimeKind.Local);
            var properties = new List<LogEventProperty>
            {
                new LogEventProperty("ActivityId", new ScalarValue(eventRecord.ActivityId)),
                new LogEventProperty("EventLogId", new ScalarValue(eventRecord.Id)),
                new LogEventProperty("Keywords", new ScalarValue(eventRecord.Keywords)),
                new LogEventProperty("MachineName", new ScalarValue(eventRecord.MachineName)),
                new LogEventProperty("TaskDisplayName", new ScalarValue(eventRecord.TaskDisplayName)),
                new LogEventProperty("LogName", new ScalarValue(eventRecord.LogName))
            };

            Event iisEvent = eventRecord.ToXml().ParseXML<Event>();
            foreach (var prop in iisEvent.EventData)
            {
                properties.Add(new LogEventProperty(prop.Name, new ScalarValue(prop.Value)));
            }

            if(eventRecord.Id == 6200)
            {
                template = new MessageTemplateParser()
                    .Parse($"{iisEvent.EventData.First(p => p.Name == "cs-method").Value} request with status {iisEvent.EventData.First(p => p.Name == "sc-status").Value} on {iisEvent.EventData.First(p => p.Name == "s-sitename").Value} -- {iisEvent.EventData.First(p => p.Name == "cs-uri-stem").Value}");
            }

            var logEvent = new LogEvent(datetimeOffset, LogEventLevel.Information, null, template, properties);
            Log.Logger.Write(logEvent);
        }
    }
}
