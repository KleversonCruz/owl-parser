using OwlParser.Lib.Schemas.Bpmn;
using OwlParser.Lib.Schemas.Owl;
using System;
using System.IO;
using System.Text;
using Xunit;

namespace OwlParser.Lib.Test
{
    public class XmlUtilTest
    {
        [Fact]
        public void DeserializeString_ValidXmlString_OntologyObject()
        {
            var file = PathUtil.GetFileInOwlPath("AQU1.xml");
            var fileContent = Encoding.UTF8.GetString(File.ReadAllBytes(file));

            var ontology = XmlUtil.DeserializeString<Ontology>(fileContent);

            Assert.NotNull(ontology);
        }

        [Fact]
        public void DeserializeString_InvalidXmlString_Exception()
        {
            var exception = Assert.Throws<Exception>(() => XmlUtil.DeserializeString<Ontology>(""));
            Assert.Contains("Houve um erro ao carregar o XML", exception.Message);
        }

        [Fact]
        public void SerializeObject_ValidDocumentBpmnObject_XmlString()
        {
            DocumentBpmn documentBpmn = new();

            var ontology = XmlUtil.SerializeObject(documentBpmn);

            Assert.Contains("xml", ontology);
        }

        [Fact]
        public void SerializeObject_InvalidDocumentBpmnObject_Exception()
        {
            var exception = Assert.Throws<Exception>(() => XmlUtil.SerializeObject<DocumentBpmn>(null));
            Assert.Contains("Houve um erro ao gerar XML", exception.Message);
        }
    }
}
