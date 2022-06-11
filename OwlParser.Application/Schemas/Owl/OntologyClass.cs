using System.Xml.Serialization;

namespace OwlParser.App.Schemas.Owl
{

    public partial class OntologyClass
    {
        [XmlElement("Class")]
        public ClassAttribute[] Class { get; set; }

        [XmlArrayItem("ObjectSomeValuesFrom", IsNullable = false)]
        public OntologyObjectSomeValues[] ObjectIntersectionOf { get; set; }
        public OntologyObjectSomeValues ObjectSomeValuesFrom { get; set; }

        public partial class OntologyObjectSomeValues
        {
            public ClassAttribute ObjectProperty { get; set; }

            public ClassAttribute Class { get; set; }
        }

    }
}
