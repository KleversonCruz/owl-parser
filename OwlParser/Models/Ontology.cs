using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace OwlParser.Models
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

        public IEnumerable<OntologyEquivalentClasses> GetEquivalentClassesList(string className)
        {
            return this.EquivalentClasses.ToList().Where(x => x.Class.IRI == className);
        }

        public string[] GetDeclarationNames()
        {
            List<string> nameList = new();
            foreach (var declaration in Declaration)
            {
                if (declaration.Class != null)
                {
                    nameList.Add(declaration.Class.IRI);
                }
            }
            return nameList.ToArray();
        }

        public OntologySubClassOf GetSubClassByName(string name)
        {
            return SubClassOf.ToList().Where(x => x.Class.First().IRI == name && x.ObjectSomeValuesFrom != null).First();
        }
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

        public string[] GetChildrenNames()
        {
            List<string> nameList = new();

            if (ObjectSomeValuesFrom != null)
            {
                nameList.Add(ObjectSomeValuesFrom.Class.IRI);
            }

            if (ObjectIntersectionOf != null)
            {
                foreach (var item in ObjectIntersectionOf)
                {
                    nameList.Add(item.Class.IRI);
                }
            }

            return nameList.ToArray();
        }
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

        public string[] GetChildrenNames()
        {
            List<string> nameList = new();

            if (ObjectSomeValuesFrom != null)
            {
                nameList.Add(ObjectSomeValuesFrom.Class.IRI);
            }

            if (ObjectIntersectionOf != null)
            {
                foreach (var item in ObjectIntersectionOf)
                {
                    nameList.Add(item.Class.IRI);
                }
            }

            return nameList.ToArray();
        }

    }

}