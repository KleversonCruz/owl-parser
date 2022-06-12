using System.Xml.Serialization;

namespace OwlParser.Lib.Schemas.Owl
{

    public partial class ClassAttribute
    {
        [XmlAttribute()]
        public string IRI { get; set; }
    }

}
