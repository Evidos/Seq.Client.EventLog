using Serilog.Events;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Seq.Client.EventLog
{
    public static class Extensions
    {
        private static LogEventLevel MapLogLevel(EventLogEntryType type)
        {
            return type switch
            {
                EventLogEntryType.Information  => LogEventLevel.Information,
                EventLogEntryType.Warning      => LogEventLevel.Warning,
                EventLogEntryType.Error        => LogEventLevel.Error,
                EventLogEntryType.SuccessAudit => LogEventLevel.Information,
                EventLogEntryType.FailureAudit => LogEventLevel.Warning,
                _                              => LogEventLevel.Debug,
            };
        }

        public static RawEvents ToDto(this EventLogEntry entry, string logName)
        {
            return new RawEvents
            {
                Events = new[]
                {
                    new RawEvent
                    {
                        Timestamp = entry.TimeGenerated,
                        Level = MapLogLevel(entry.EntryType),
                        MessageTemplate = entry.Message,
                        Properties = new Dictionary<string, object>
                        {
                            { "MachineName", entry.MachineName },
#pragma warning disable 618
                            { "EventId", entry.EventID },
#pragma warning restore 618
                            { "InstanceId", entry.InstanceId },
                            { "EventSource", entry.Source },
                            { "Category", entry.CategoryNumber },
                            { "EventLogName", logName }
                        }
                    },
                }
            };
        }

        public static T ParseXML<T>(this string @this) where T : class
        {
            var reader = XmlReader.Create(@this.Trim().ToStream(), new XmlReaderSettings() { ConformanceLevel = ConformanceLevel.Document });
            return new XmlSerializer(typeof(T)).Deserialize(reader) as T;
        }

        public static Stream ToStream(this string @this)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(@this);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
