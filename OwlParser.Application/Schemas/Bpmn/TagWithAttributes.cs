using System;
using System.Xml.Serialization;

namespace OwlParser.App.Schemas.Bpmn
{
    public abstract class TagWithAttributes
    {
        public TagWithAttributes()
        {
            Id = $"Id_{Guid.NewGuid()}";
        }

        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}
