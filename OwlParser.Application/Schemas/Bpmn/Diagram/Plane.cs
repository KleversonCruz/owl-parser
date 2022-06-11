using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace OwlParser.App.Schemas.Bpmn.Diagram
{
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
    public partial class Plane: ElementAttributes
    {
        public Plane()
        {
            BPMNShapes = new();
            BPMNEdges = new();
        }

        [XmlAttribute("extension", Namespace = "http://www.omg.org/spec/DD/20100524/DI")]
        public string Extension { get; set; }

        [XmlElement("BPMNShape")]
        public List<Shape> BPMNShapes { get; set; }

        [XmlElement("BPMNEdge")]
        public List<Edge> BPMNEdges { get; set; }
    }
}
