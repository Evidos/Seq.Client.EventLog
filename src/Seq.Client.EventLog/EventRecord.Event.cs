// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/win/2004/08/events/event")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/win/2004/08/events/event", IsNullable = false)]
public partial class Event
{

    private EventSystem systemField;

    private EventData[] eventDataField;

    /// <remarks/>
    public EventSystem System
    {
        get
        {
            return this.systemField;
        }
        set
        {
            this.systemField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Data", IsNullable = false)]
    public EventData[] EventData
    {
        get
        {
            return this.eventDataField;
        }
        set
        {
            this.eventDataField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/win/2004/08/events/event")]
public partial class EventSystem
{

    private EventSystemProvider providerField;

    private ushort eventIDField;

    private byte versionField;

    private byte levelField;

    private byte taskField;

    private byte opcodeField;

    private string keywordsField;

    private EventSystemTimeCreated timeCreatedField;

    private uint eventRecordIDField;

    private object correlationField;

    private EventSystemExecution executionField;

    private string channelField;

    private string computerField;

    private EventSystemSecurity securityField;

    /// <remarks/>
    public EventSystemProvider Provider
    {
        get
        {
            return this.providerField;
        }
        set
        {
            this.providerField = value;
        }
    }

    /// <remarks/>
    public ushort EventID
    {
        get
        {
            return this.eventIDField;
        }
        set
        {
            this.eventIDField = value;
        }
    }

    /// <remarks/>
    public byte Version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }

    /// <remarks/>
    public byte Level
    {
        get
        {
            return this.levelField;
        }
        set
        {
            this.levelField = value;
        }
    }

    /// <remarks/>
    public byte Task
    {
        get
        {
            return this.taskField;
        }
        set
        {
            this.taskField = value;
        }
    }

    /// <remarks/>
    public byte Opcode
    {
        get
        {
            return this.opcodeField;
        }
        set
        {
            this.opcodeField = value;
        }
    }

    /// <remarks/>
    public string Keywords
    {
        get
        {
            return this.keywordsField;
        }
        set
        {
            this.keywordsField = value;
        }
    }

    /// <remarks/>
    public EventSystemTimeCreated TimeCreated
    {
        get
        {
            return this.timeCreatedField;
        }
        set
        {
            this.timeCreatedField = value;
        }
    }

    /// <remarks/>
    public uint EventRecordID
    {
        get
        {
            return this.eventRecordIDField;
        }
        set
        {
            this.eventRecordIDField = value;
        }
    }

    /// <remarks/>
    public object Correlation
    {
        get
        {
            return this.correlationField;
        }
        set
        {
            this.correlationField = value;
        }
    }

    /// <remarks/>
    public EventSystemExecution Execution
    {
        get
        {
            return this.executionField;
        }
        set
        {
            this.executionField = value;
        }
    }

    /// <remarks/>
    public string Channel
    {
        get
        {
            return this.channelField;
        }
        set
        {
            this.channelField = value;
        }
    }

    /// <remarks/>
    public string Computer
    {
        get
        {
            return this.computerField;
        }
        set
        {
            this.computerField = value;
        }
    }

    /// <remarks/>
    public EventSystemSecurity Security
    {
        get
        {
            return this.securityField;
        }
        set
        {
            this.securityField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/win/2004/08/events/event")]
public partial class EventSystemProvider
{

    private string nameField;

    private string guidField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Guid
    {
        get
        {
            return this.guidField;
        }
        set
        {
            this.guidField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/win/2004/08/events/event")]
public partial class EventSystemTimeCreated
{

    private System.DateTime systemTimeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime SystemTime
    {
        get
        {
            return this.systemTimeField;
        }
        set
        {
            this.systemTimeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/win/2004/08/events/event")]
public partial class EventSystemExecution
{

    private ushort processIDField;

    private ushort threadIDField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort ProcessID
    {
        get
        {
            return this.processIDField;
        }
        set
        {
            this.processIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort ThreadID
    {
        get
        {
            return this.threadIDField;
        }
        set
        {
            this.threadIDField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/win/2004/08/events/event")]
public partial class EventSystemSecurity
{

    private string userIDField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string UserID
    {
        get
        {
            return this.userIDField;
        }
        set
        {
            this.userIDField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/win/2004/08/events/event")]
public partial class EventData
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

