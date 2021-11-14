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
        public OntologyEquivalentClassesClass Class { get; set; }


        public OntologyEquivalentClassesObjectSomeValuesFrom ObjectSomeValuesFrom { get; set; }


        [XmlArrayItem("ObjectSomeValuesFrom", IsNullable = false)]
        public OntologyEquivalentClassesObjectSomeValuesFrom1[] ObjectIntersectionOf { get; set; }
    }


    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyEquivalentClassesClass
    {
        [XmlAttribute()]
        public string IRI { get; set; }
    }


    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyEquivalentClassesObjectSomeValuesFrom
    {
        public OntologyEquivalentClassesObjectSomeValuesFromObjectProperty ObjectProperty { get; set; }

        public OntologyEquivalentClassesObjectSomeValuesFromClass Class { get; set; }
    }


    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyEquivalentClassesObjectSomeValuesFromObjectProperty
    {
        [XmlAttribute()]
        public string IRI { get; set; }
    }


    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyEquivalentClassesObjectSomeValuesFromClass
    {
        [XmlAttribute()]
        public string IRI { get; set; }
    }


    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyEquivalentClassesObjectSomeValuesFrom1
    {
        public OntologyEquivalentClassesObjectSomeValuesFromObjectProperty1 ObjectProperty { get; set; }


        public OntologyEquivalentClassesObjectSomeValuesFromClass1 Class { get; set; }
    }


    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyEquivalentClassesObjectSomeValuesFromObjectProperty1
    {
        [XmlAttribute()]
        public string IRI { get; set; }
    }


    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyEquivalentClassesObjectSomeValuesFromClass1
    {
        [XmlAttribute()]
        public string IRI { get; set; }
    }


}