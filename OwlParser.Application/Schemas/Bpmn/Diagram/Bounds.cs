using System;
using System.Xml.Serialization;

namespace OwlParser.App.Schemas.Bpmn.Diagram
{
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/DD/20100524/DC")]
    [XmlRoot(Namespace = "http://www.omg.org/spec/DD/20100524/DC", IsNullable = false)]
    public partial class Bounds
    {
        public Bounds()
        {

        }
        public Bounds(string x, string y, string width, string height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        [XmlAttribute("x")]
        public string X { get; set; }


        [XmlAttribute("y")]
        public string Y { get; set; }

        [XmlAttribute("width")]
        public string Width { get; set; }


        [XmlAttribute("height")]
        public string Height { get; set; }
    }
}
