using System;
using System.Xml.Serialization;

namespace OwlParser.Lib.Schemas.Bpmn.Diagram
{

    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/DD/20100524/DI")]
    [XmlRoot(Namespace = "http://www.omg.org/spec/DD/20100524/DI", IsNullable = false)]
    public partial class Waypoint
    {
        public Waypoint()
        {

        }

        public Waypoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        [XmlAttribute("x")]
        public int X { get; set; }


        [XmlAttribute("y")]
        public int Y { get; set; }
    }
}
