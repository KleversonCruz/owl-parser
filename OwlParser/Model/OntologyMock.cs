using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwlParser.Model
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2002/07/owl#", IsNullable = false)]
    public partial class Ontology
    {

        private OntologyPrefix[] prefixField;

        private OntologyAnnotation[] annotationField;

        private OntologyDeclaration[] declarationField;

        private OntologyEquivalentClasses[] equivalentClassesField;

        private OntologySubClassOf[] subClassOfField;

        private OntologyClassAssertion[] classAssertionField;

        private OntologyDataPropertyAssertion[] dataPropertyAssertionField;

        private OntologyObjectProperty[] subObjectPropertyOfField;

        private OntologyInverseObjectPropertiesObjectProperty[][] inverseObjectPropertiesField;

        private OntologyTransitiveObjectProperty[] transitiveObjectPropertyField;

        private OntologyFunctionalDataProperty functionalDataPropertyField;

        private OntologyAnnotationAssertion[] annotationAssertionField;

        private string baseField;

        private string ontologyIRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Prefix")]
        public OntologyPrefix[] Prefix
        {
            get
            {
                return this.prefixField;
            }
            set
            {
                this.prefixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Annotation")]
        public OntologyAnnotation[] Annotation
        {
            get
            {
                return this.annotationField;
            }
            set
            {
                this.annotationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Declaration")]
        public OntologyDeclaration[] Declaration
        {
            get
            {
                return this.declarationField;
            }
            set
            {
                this.declarationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquivalentClasses")]
        public OntologyEquivalentClasses[] EquivalentClasses
        {
            get
            {
                return this.equivalentClassesField;
            }
            set
            {
                this.equivalentClassesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubClassOf")]
        public OntologySubClassOf[] SubClassOf
        {
            get
            {
                return this.subClassOfField;
            }
            set
            {
                this.subClassOfField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClassAssertion")]
        public OntologyClassAssertion[] ClassAssertion
        {
            get
            {
                return this.classAssertionField;
            }
            set
            {
                this.classAssertionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataPropertyAssertion")]
        public OntologyDataPropertyAssertion[] DataPropertyAssertion
        {
            get
            {
                return this.dataPropertyAssertionField;
            }
            set
            {
                this.dataPropertyAssertionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ObjectProperty", IsNullable = false)]
        public OntologyObjectProperty[] SubObjectPropertyOf
        {
            get
            {
                return this.subObjectPropertyOfField;
            }
            set
            {
                this.subObjectPropertyOfField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ObjectProperty", typeof(OntologyInverseObjectPropertiesObjectProperty), IsNullable = false)]
        public OntologyInverseObjectPropertiesObjectProperty[][] InverseObjectProperties
        {
            get
            {
                return this.inverseObjectPropertiesField;
            }
            set
            {
                this.inverseObjectPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransitiveObjectProperty")]
        public OntologyTransitiveObjectProperty[] TransitiveObjectProperty
        {
            get
            {
                return this.transitiveObjectPropertyField;
            }
            set
            {
                this.transitiveObjectPropertyField = value;
            }
        }

        /// <remarks/>
        public OntologyFunctionalDataProperty FunctionalDataProperty
        {
            get
            {
                return this.functionalDataPropertyField;
            }
            set
            {
                this.functionalDataPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AnnotationAssertion")]
        public OntologyAnnotationAssertion[] AnnotationAssertion
        {
            get
            {
                return this.annotationAssertionField;
            }
            set
            {
                this.annotationAssertionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string @base
        {
            get
            {
                return this.baseField;
            }
            set
            {
                this.baseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ontologyIRI
        {
            get
            {
                return this.ontologyIRIField;
            }
            set
            {
                this.ontologyIRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyPrefix
    {

        private string nameField;

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyAnnotation
    {

        private OntologyAnnotationAnnotationProperty annotationPropertyField;

        private OntologyAnnotationLiteral literalField;

        /// <remarks/>
        public OntologyAnnotationAnnotationProperty AnnotationProperty
        {
            get
            {
                return this.annotationPropertyField;
            }
            set
            {
                this.annotationPropertyField = value;
            }
        }

        /// <remarks/>
        public OntologyAnnotationLiteral Literal
        {
            get
            {
                return this.literalField;
            }
            set
            {
                this.literalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyAnnotationAnnotationProperty
    {

        private string abbreviatedIRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string abbreviatedIRI
        {
            get
            {
                return this.abbreviatedIRIField;
            }
            set
            {
                this.abbreviatedIRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyAnnotationLiteral
    {

        private string langField;

        private string datatypeIRIField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string datatypeIRI
        {
            get
            {
                return this.datatypeIRIField;
            }
            set
            {
                this.datatypeIRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyDeclaration
    {

        private OntologyDeclarationAnnotationProperty annotationPropertyField;

        private OntologyDeclarationNamedIndividual namedIndividualField;

        private OntologyDeclarationDataProperty dataPropertyField;

        private OntologyDeclarationObjectProperty objectPropertyField;

        private OntologyDeclarationClass classField;

        /// <remarks/>
        public OntologyDeclarationAnnotationProperty AnnotationProperty
        {
            get
            {
                return this.annotationPropertyField;
            }
            set
            {
                this.annotationPropertyField = value;
            }
        }

        /// <remarks/>
        public OntologyDeclarationNamedIndividual NamedIndividual
        {
            get
            {
                return this.namedIndividualField;
            }
            set
            {
                this.namedIndividualField = value;
            }
        }

        /// <remarks/>
        public OntologyDeclarationDataProperty DataProperty
        {
            get
            {
                return this.dataPropertyField;
            }
            set
            {
                this.dataPropertyField = value;
            }
        }

        /// <remarks/>
        public OntologyDeclarationObjectProperty ObjectProperty
        {
            get
            {
                return this.objectPropertyField;
            }
            set
            {
                this.objectPropertyField = value;
            }
        }

        /// <remarks/>
        public OntologyDeclarationClass Class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyDeclarationAnnotationProperty
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyDeclarationNamedIndividual
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyDeclarationDataProperty
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyDeclarationObjectProperty
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyDeclarationClass
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyEquivalentClasses
    {

        private OntologyEquivalentClassesClass classField;

        private OntologyEquivalentClassesObjectSomeValuesFrom objectSomeValuesFromField;

        private OntologyEquivalentClassesObjectSomeValuesFrom1[] objectIntersectionOfField;

        /// <remarks/>
        public OntologyEquivalentClassesClass Class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

        /// <remarks/>
        public OntologyEquivalentClassesObjectSomeValuesFrom ObjectSomeValuesFrom
        {
            get
            {
                return this.objectSomeValuesFromField;
            }
            set
            {
                this.objectSomeValuesFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ObjectSomeValuesFrom", IsNullable = false)]
        public OntologyEquivalentClassesObjectSomeValuesFrom1[] ObjectIntersectionOf
        {
            get
            {
                return this.objectIntersectionOfField;
            }
            set
            {
                this.objectIntersectionOfField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyEquivalentClassesClass
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyEquivalentClassesObjectSomeValuesFrom
    {

        private OntologyEquivalentClassesObjectSomeValuesFromObjectProperty objectPropertyField;

        private OntologyEquivalentClassesObjectSomeValuesFromClass classField;

        /// <remarks/>
        public OntologyEquivalentClassesObjectSomeValuesFromObjectProperty ObjectProperty
        {
            get
            {
                return this.objectPropertyField;
            }
            set
            {
                this.objectPropertyField = value;
            }
        }

        /// <remarks/>
        public OntologyEquivalentClassesObjectSomeValuesFromClass Class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyEquivalentClassesObjectSomeValuesFromObjectProperty
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyEquivalentClassesObjectSomeValuesFromClass
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyEquivalentClassesObjectSomeValuesFrom1
    {

        private OntologyEquivalentClassesObjectSomeValuesFromObjectProperty1 objectPropertyField;

        private OntologyEquivalentClassesObjectSomeValuesFromClass1 classField;

        /// <remarks/>
        public OntologyEquivalentClassesObjectSomeValuesFromObjectProperty1 ObjectProperty
        {
            get
            {
                return this.objectPropertyField;
            }
            set
            {
                this.objectPropertyField = value;
            }
        }

        /// <remarks/>
        public OntologyEquivalentClassesObjectSomeValuesFromClass1 Class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyEquivalentClassesObjectSomeValuesFromObjectProperty1
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyEquivalentClassesObjectSomeValuesFromClass1
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologySubClassOf
    {

        private OntologySubClassOfClass[] classField;

        private OntologySubClassOfObjectSomeValuesFrom[] objectIntersectionOfField;

        private OntologySubClassOfObjectSomeValuesFrom1 objectSomeValuesFromField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Class")]
        public OntologySubClassOfClass[] Class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ObjectSomeValuesFrom", IsNullable = false)]
        public OntologySubClassOfObjectSomeValuesFrom[] ObjectIntersectionOf
        {
            get
            {
                return this.objectIntersectionOfField;
            }
            set
            {
                this.objectIntersectionOfField = value;
            }
        }

        /// <remarks/>
        public OntologySubClassOfObjectSomeValuesFrom1 ObjectSomeValuesFrom
        {
            get
            {
                return this.objectSomeValuesFromField;
            }
            set
            {
                this.objectSomeValuesFromField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologySubClassOfClass
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologySubClassOfObjectSomeValuesFrom
    {

        private OntologySubClassOfObjectSomeValuesFromObjectProperty objectPropertyField;

        private OntologySubClassOfObjectSomeValuesFromClass classField;

        /// <remarks/>
        public OntologySubClassOfObjectSomeValuesFromObjectProperty ObjectProperty
        {
            get
            {
                return this.objectPropertyField;
            }
            set
            {
                this.objectPropertyField = value;
            }
        }

        /// <remarks/>
        public OntologySubClassOfObjectSomeValuesFromClass Class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologySubClassOfObjectSomeValuesFromObjectProperty
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologySubClassOfObjectSomeValuesFromClass
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologySubClassOfObjectSomeValuesFrom1
    {

        private OntologySubClassOfObjectSomeValuesFromObjectProperty1 objectPropertyField;

        private OntologySubClassOfObjectSomeValuesFromClass1 classField;

        /// <remarks/>
        public OntologySubClassOfObjectSomeValuesFromObjectProperty1 ObjectProperty
        {
            get
            {
                return this.objectPropertyField;
            }
            set
            {
                this.objectPropertyField = value;
            }
        }

        /// <remarks/>
        public OntologySubClassOfObjectSomeValuesFromClass1 Class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologySubClassOfObjectSomeValuesFromObjectProperty1
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologySubClassOfObjectSomeValuesFromClass1
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyClassAssertion
    {

        private OntologyClassAssertionClass classField;

        private OntologyClassAssertionNamedIndividual namedIndividualField;

        /// <remarks/>
        public OntologyClassAssertionClass Class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

        /// <remarks/>
        public OntologyClassAssertionNamedIndividual NamedIndividual
        {
            get
            {
                return this.namedIndividualField;
            }
            set
            {
                this.namedIndividualField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyClassAssertionClass
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyClassAssertionNamedIndividual
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyDataPropertyAssertion
    {

        private OntologyDataPropertyAssertionDataProperty dataPropertyField;

        private OntologyDataPropertyAssertionNamedIndividual namedIndividualField;

        private OntologyDataPropertyAssertionLiteral literalField;

        /// <remarks/>
        public OntologyDataPropertyAssertionDataProperty DataProperty
        {
            get
            {
                return this.dataPropertyField;
            }
            set
            {
                this.dataPropertyField = value;
            }
        }

        /// <remarks/>
        public OntologyDataPropertyAssertionNamedIndividual NamedIndividual
        {
            get
            {
                return this.namedIndividualField;
            }
            set
            {
                this.namedIndividualField = value;
            }
        }

        /// <remarks/>
        public OntologyDataPropertyAssertionLiteral Literal
        {
            get
            {
                return this.literalField;
            }
            set
            {
                this.literalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyDataPropertyAssertionDataProperty
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyDataPropertyAssertionNamedIndividual
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyDataPropertyAssertionLiteral
    {

        private string langField;

        private string datatypeIRIField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string datatypeIRI
        {
            get
            {
                return this.datatypeIRIField;
            }
            set
            {
                this.datatypeIRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyObjectProperty
    {

        private string iRIField;

        private string abbreviatedIRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string abbreviatedIRI
        {
            get
            {
                return this.abbreviatedIRIField;
            }
            set
            {
                this.abbreviatedIRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyInverseObjectPropertiesObjectProperty
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyTransitiveObjectProperty
    {

        private OntologyTransitiveObjectPropertyObjectProperty objectPropertyField;

        /// <remarks/>
        public OntologyTransitiveObjectPropertyObjectProperty ObjectProperty
        {
            get
            {
                return this.objectPropertyField;
            }
            set
            {
                this.objectPropertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyTransitiveObjectPropertyObjectProperty
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyFunctionalDataProperty
    {

        private OntologyFunctionalDataPropertyDataProperty dataPropertyField;

        /// <remarks/>
        public OntologyFunctionalDataPropertyDataProperty DataProperty
        {
            get
            {
                return this.dataPropertyField;
            }
            set
            {
                this.dataPropertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyFunctionalDataPropertyDataProperty
    {

        private string iRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyAnnotationAssertion
    {

        private OntologyAnnotationAssertionAnnotationProperty annotationPropertyField;

        private string abbreviatedIRIField;

        private string iRIField;

        private OntologyAnnotationAssertionLiteral literalField;

        /// <remarks/>
        public OntologyAnnotationAssertionAnnotationProperty AnnotationProperty
        {
            get
            {
                return this.annotationPropertyField;
            }
            set
            {
                this.annotationPropertyField = value;
            }
        }

        /// <remarks/>
        public string AbbreviatedIRI
        {
            get
            {
                return this.abbreviatedIRIField;
            }
            set
            {
                this.abbreviatedIRIField = value;
            }
        }

        /// <remarks/>
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }

        /// <remarks/>
        public OntologyAnnotationAssertionLiteral Literal
        {
            get
            {
                return this.literalField;
            }
            set
            {
                this.literalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyAnnotationAssertionAnnotationProperty
    {

        private string iRIField;

        private string abbreviatedIRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IRI
        {
            get
            {
                return this.iRIField;
            }
            set
            {
                this.iRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string abbreviatedIRI
        {
            get
            {
                return this.abbreviatedIRIField;
            }
            set
            {
                this.abbreviatedIRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2002/07/owl#")]
    public partial class OntologyAnnotationAssertionLiteral
    {

        private string langField;

        private string datatypeIRIField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string datatypeIRI
        {
            get
            {
                return this.datatypeIRIField;
            }
            set
            {
                this.datatypeIRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }


}
