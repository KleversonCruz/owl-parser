using OwlParser.App.Schemas.Bpmn;
using OwlParser.App.Schemas.Owl;
using System.Collections.Generic;
using System.Linq;

namespace OwlParser.App
{
    public class Parser
    {
        public RootDefinitions ToBpmn(Ontology ontology)
        {
            var classes = GetClassTree(ontology);
            List<Process> processList = new();
            DiagramBuilder diagramBuilder = new();

            foreach (var ontologyClass in classes)
            {
                ProcessBuilder processBuilder = new();
                processBuilder.WithTask(ontologyClass.ObjectIntersectionOf);
                var process = processBuilder.Build(ontologyClass.Class.First().IRI);
                processList.Add(process);

                diagramBuilder
                    .WithProcess(process)
                    .WithTasks(processBuilder.Tasks)
                    .WithSequenceFlows(processBuilder.SequenceFlows)
                    .WithEvent(processBuilder.EndEvent)
                    .WithEvent(processBuilder.StartEvent);

            }

            return new RootDefinitions(processList, diagramBuilder.Build());
        }

        private List<OntologyClass> GetClassTree(Ontology ontology)
        {
            List<OntologyClass> subClassNamesList = new();

            foreach (var equivalentClass in ontology.EquivalentClasses)
            {
                subClassNamesList.Add(equivalentClass);
            }
            return subClassNamesList;
        }

    }
}
