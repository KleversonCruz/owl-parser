using System;
using System.Xml.Serialization;

namespace OwlParser.Lib.Schemas.Bpmn
{
    public abstract class ProcessElementAttributes
    {
        public ProcessElementAttributes()
        {
            Id = $"Id_{Guid.NewGuid()}";
        }

        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}
