using System.Xml.Serialization;

namespace OwlParser.Lib.Schemas.Bpmn.Diagram
{
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
    public partial class Shape: ElementAttributes
    {
        public Shape()
        {

        }
        public Shape(string elementId)
        {
            BpmnElement = elementId;
        }

        [XmlAttribute("extension", Namespace = "http://www.omg.org/spec/DD/20100524/DI")]
        public string Extension { get; set; }


        [XmlElement(Namespace = "http://www.omg.org/spec/DD/20100524/DC")]
        public Bounds Bounds { get; set; }
    }
}
