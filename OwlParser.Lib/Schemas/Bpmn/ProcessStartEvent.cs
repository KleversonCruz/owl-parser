using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace OwlParser.Lib.Schemas.Bpmn
{

    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
    public partial class ProcessStartEvent : ProcessElementAttributes
    {
        [XmlElement("outgoing")]
        public List<string> Outgoing = new();
    }
}
