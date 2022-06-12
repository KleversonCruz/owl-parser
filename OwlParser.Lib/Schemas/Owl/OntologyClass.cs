using System.Collections.Generic;
using System.Xml.Serialization;

namespace OwlParser.Lib.Schemas.Owl
{

    public partial class OntologyClass
    {
        public OntologyClass()
        {
            Class = new();
            ObjectSomeValuesFrom = new();
        }

        [XmlElement("Class")]
        public List<ClassAttribute> Class { get; set; }

        [XmlArrayItem("ObjectSomeValuesFrom", IsNullable = false)]
        public List<OntologyObjectSomeValues> ObjectIntersectionOf { get; set; }
        public OntologyObjectSomeValues ObjectSomeValuesFrom { get; set; }

        public partial class OntologyObjectSomeValues
        {
            public ClassAttribute ObjectProperty { get; set; }

            public ClassAttribute Class { get; set; }
        }

    }
}
