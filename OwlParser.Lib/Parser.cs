using OwlParser.Lib.Schemas.Bpmn;
using OwlParser.Lib.Schemas.Owl;
using OwlParser.Lib;
using System.Collections.Generic;
using System.Linq;
using OwlParser.Lib.Schemas;

namespace OwlParser.Lib
{
    public class Parser
    {
        private Ontology ontology { get; set; }
        public Parser(string xmlString)
        {
            ontology = XmlUtil.DeserializeString<Ontology>(xmlString);
        }

        public List<DocumentBpmn> ToBpmn()
        {
            List<DocumentBpmn> DocumentsBpmn = new();
            foreach (var ontologyClass in ontology.EquivalentClasses)
            {
                List<Process> processList = new();
                ProcessBuilder processBuilder = new();
                processBuilder.WithTask(ontologyClass.ObjectIntersectionOf);
                var process = processBuilder.Build(ontologyClass.Class.First().IRI);
                processList.Add(process);

                DiagramBuilder diagramBuilder = new();
                diagramBuilder
                    .WithProcess(process)
                    .WithTasks(processBuilder.Tasks)
                    .WithSequenceFlows(processBuilder.SequenceFlows)
                    .WithEvent(processBuilder.EndEvent)
                    .WithEvent(processBuilder.StartEvent);

                DocumentsBpmn.Add(new DocumentBpmn(processList, diagramBuilder.Build()));
            }
            return DocumentsBpmn;
        }

        public List<string> ToBpmnString()
        {
            List<string> XmlStrings = new();
            foreach (DocumentBpmn item in ToBpmn())
            {
                XmlStrings.Add(XmlUtil.SerializeObject(item));
            }
            return XmlStrings;
        }

        public List<XmlFile> ToBpmnXmlFile()
        {
            List<XmlFile> fileList = new();
            foreach (DocumentBpmn item in ToBpmn())
            {
                fileList.Add(new XmlFile(item.process.First().Name, (XmlUtil.SerializeObject(item))));
            }
            return fileList;
        }
    }
}
