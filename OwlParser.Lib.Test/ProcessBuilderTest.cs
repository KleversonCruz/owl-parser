using OwlParser.Lib.Schemas.Owl;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;

namespace OwlParser.Lib.Test
{
    public class ProcessBuilderTest
    {
        private ProcessBuilder processBuilder;

        public ProcessBuilderTest()
        {
            processBuilder = new();

        }

        private Ontology LoadOntology(string fileName)
        {
            string file = PathUtil.GetFileInOwlPath(fileName);
            string fileContent = Encoding.UTF8.GetString(File.ReadAllBytes(file));
            return XmlUtil.DeserializeString<Ontology>(fileContent);
        }

        [Fact]
        public void WithTask_OntologyClass_AddedTaskInList()
        {
            var ontology = LoadOntology("AQU1.xml");
            var ontologyClass = ontology.EquivalentClasses.First().ObjectIntersectionOf;

            processBuilder.WithTask(ontologyClass);

            Assert.Contains(processBuilder.Tasks, t => t.Name == ontologyClass.First().Class.IRI);
            Assert.Equal(4, processBuilder.Tasks.Count);
        }

        [Fact]
        public void Build_ProcessName_ProcessObject()
        {
            var ontology = LoadOntology("AQU1.xml");
            var ontologyClass = ontology.EquivalentClasses.First().ObjectIntersectionOf;

            processBuilder.WithTask(ontologyClass);
            var process = processBuilder.Build(ontology.EquivalentClasses.First().Class.First().IRI);

            Assert.Equal(8, processBuilder.SequenceFlows.Count);
            Assert.Equal(8, processBuilder.SequenceFlows.Count);
            Assert.Equal(process.Name, processBuilder.EndEvent.Name);

            Assert.Equal(ontology.EquivalentClasses.First().Class.First().IRI, process.Name);
        }
    }
}
