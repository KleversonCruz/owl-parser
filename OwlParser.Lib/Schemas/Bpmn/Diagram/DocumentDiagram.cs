using System;
using System.Xml.Serialization;

namespace OwlParser.Lib.Schemas.Bpmn.Diagram
{

    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
    [XmlRoot("BPMNDiagram", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI", IsNullable = false)]
    public partial class DocumentDiagram
    {
        public Plane BPMNPlane { get; set; }

        [XmlAttribute("id")]
        public string Id { get; set; }
    }
}
