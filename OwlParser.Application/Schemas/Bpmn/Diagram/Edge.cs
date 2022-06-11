using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace OwlParser.App.Schemas.Bpmn.Diagram
{

    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
    public partial class Edge : ElementAttributes
    {
        public Edge()
        {

        }
        public Edge(string elementId)
        {
            BpmnElement = elementId;
            Waypoint = new();
        }

        [XmlAttribute("extension", Namespace = "http://www.omg.org/spec/DD/20100524/DI")]
        public string Extension { get; set; }


        [XmlElement("waypoint", Namespace = "http://www.omg.org/spec/DD/20100524/DI")]
        public List<Waypoint> Waypoint { get; set; }

    }
}
