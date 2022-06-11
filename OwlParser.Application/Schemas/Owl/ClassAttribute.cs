using System.Xml.Serialization;

namespace OwlParser.App.Schemas.Owl
{

    public partial class ClassAttribute
    {
        [XmlAttribute()]
        public string IRI { get; set; }
    }

}
