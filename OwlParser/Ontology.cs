using System;
using System.Xml.Serialization;

namespace OwlParser
{
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    [XmlRoot(Namespace = "http://www.w3.org/2002/07/owl#", IsNullable = false)]
    public class Ontology
    {
        [XmlElement("Declaration")]
        public OntologyDeclaration[] Declaration { get; set; }

        [XmlElement("EquivalentClasses")]
        public OntologyEquivalentClasses[] EquivalentClasses { get; set; }

        [XmlElement("SubClassOf")]
        public OntologySubClassOf[] SubClassOf { get; set; }
    }

    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyDeclaration
    {
        public OntologyDeclarationClass Class { get; set; }
    }

    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyDeclarationClass
    {
        [XmlAttribute()]
        public string IRI { get; set; }
    }

    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyEquivalentClasses
    {
        public OntologyDeclarationClass Class { get; set; }

        public OntologyObjectSomeValues ObjectSomeValuesFrom { get; set; }

        [XmlArrayItem("ObjectSomeValuesFrom", IsNullable = false)]
        public OntologyObjectSomeValues[] ObjectIntersectionOf { get; set; }
    }

    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyObjectSomeValues
    {
        public OntologyObjectProperty ObjectProperty { get; set; }

        public OntologyDeclarationClass Class { get; set; }
    }

    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyObjectProperty
    {
        [XmlAttribute()]
        public string IRI { get; set; }
    }

    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologySubClassOf
    {
        [XmlElement("Class")]
        public OntologyDeclarationClass[] Class { get; set; }

        [XmlArrayItem("ObjectSomeValuesFrom", IsNullable = false)]
        public OntologyObjectSomeValues[] ObjectIntersectionOf { get; set; }
        public OntologyObjectSomeValues ObjectSomeValuesFrom { get; set; }
    }
}