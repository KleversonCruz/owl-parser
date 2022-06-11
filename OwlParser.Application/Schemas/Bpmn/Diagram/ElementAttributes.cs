using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace OwlParser.App.Schemas.Bpmn.Diagram
{
    public abstract class ElementAttributes
    {
        public ElementAttributes()
        {
            Id = string.Format("DiagramElement_{0}", Guid.NewGuid());
        }

        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("bpmnElement")]
        public string BpmnElement { get; set; }
    }
}
