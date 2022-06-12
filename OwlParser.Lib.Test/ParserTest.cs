using System;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;

namespace OwlParser.Lib.Test
{
    public class ParserTest
    {
        private Parser parser;
        public ParserTest()
        {
            var file = PathUtil.GetFileInOwlPath("AQU1.xml");
            var fileContent = Encoding.UTF8.GetString(File.ReadAllBytes(file));
            parser = new(fileContent);
        }

        [Fact]
        public void ToBpmn_XmlString_DocumentBpmnList()
        {
            var documentBpmnList = parser.ToBpmn().First();

            Assert.Equal(14, documentBpmnList.process.First().Items.Count);
            Assert.Equal("#AQU1", documentBpmnList.process.First().Name);
        }

        [Fact]
        public void ToBpmnString_XmlString_BpmnXmlStringList()
        {
            var documentBpmnList = parser.ToBpmnString();

            Assert.NotNull(documentBpmnList);
            Assert.Contains("#AQU1", documentBpmnList.First());
        }
    }
}
