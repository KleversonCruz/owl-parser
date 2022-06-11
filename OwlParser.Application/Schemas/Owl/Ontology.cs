using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace OwlParser.App.Schemas.Owl
{
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    [XmlRoot(Namespace = "http://www.w3.org/2002/07/owl#", IsNullable = false)]
    public class Ontology
    {
        [XmlElement("Declaration")]
        public List<OntologyDeclaration> Declaration { get; set; }

        public partial class OntologyDeclaration
        {
            public ClassAttribute Class { get; set; }
        }

        [XmlElement("EquivalentClasses")]
        public List<OntologyClass> EquivalentClasses { get; set; }

        [XmlElement("SubClassOf")]
        public List<OntologyClass> SubClassOf { get; set; }

    }
}
