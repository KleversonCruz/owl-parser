using System;
using System.Xml.Serialization;

namespace OwlParser.App.Schemas.Bpmn.Diagram
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

        public Waypoint(string x, string y)
        {
            X = x;
            Y = y;
        }

        [XmlAttribute("x")]
        public string X { get; set; }


        [XmlAttribute("y")]
        public string Y { get; set; }
    }
}
