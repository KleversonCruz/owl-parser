using System;
using System.Xml.Serialization;

namespace OwlParser.Lib.Schemas.Bpmn.Diagram
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
        public Bounds(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        [XmlAttribute("x")]
        public int X { get; set; }


        [XmlAttribute("y")]
        public int Y { get; set; }

        [XmlAttribute("width")]
        public int Width { get; set; }


        [XmlAttribute("height")]
        public int Height { get; set; }
    }
}
