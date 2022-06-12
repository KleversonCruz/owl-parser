using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace OwlParser.Lib.Schemas.Bpmn
{

    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
    public partial class Process : ProcessElementAttributes
    {
        public Process()
        {
            Items = new();
        }

        public Process(string name)
        {
            Name = name;
            Items = new();
        }

        [XmlElement("sequenceFlow", typeof(ProcessSequenceFlow))]
        [XmlElement("task", typeof(ProcessTask))]
        [XmlElement("startEvent", typeof(ProcessStartEvent))]
        [XmlElement("endEvent", typeof(ProcessEndEvent))]
        public List<object> Items { get; set; }
    }
}
