using OwlParser.App.Schemas.Bpmn;
using System.Collections.Generic;
using static OwlParser.App.Schemas.Owl.OntologyClass;

namespace OwlParser.App
{
    internal class ProcessBuilder
    {
        public readonly List<ProcessTask> Tasks = new();
        public readonly List<ProcessSequenceFlow> SequenceFlows = new();
        public readonly ProcessEndEvent EndEvent = new();
        public readonly ProcessStartEvent StartEvent = new();

        public List<object> EventItens { get; private set; }

        public ProcessBuilder()
        {
            EventItens = new();
        }

        public Process Build(string processName)
        {
            Process process = new(processName);

            SetStartSequenceFlow("Inicio");
            SetEndSequenceFlow(processName);

            process.Items.Add(StartEvent);
            process.Items.AddRange(Tasks);
            process.Items.Add(EndEvent);
            process.Items.AddRange(SequenceFlows);


            return process;
        }

        public ProcessBuilder WithTask(OntologyObjectSomeValues[] ontologyClass)
        {
            foreach (var item in ontologyClass)
            {
                Tasks.Add(new ProcessTask(item.Class.IRI));
            }
            return this;
        }

        private void SetStartSequenceFlow(string EventName)
        {
            StartEvent.Name = EventName;
            foreach (var item in Tasks)
            {
                ProcessSequenceFlow startSequence = new(StartEvent.Id, item.Id);
                item.incoming = startSequence.Id;
                SequenceFlows.Add(startSequence);
                StartEvent.Outgoing.Add(startSequence.Id);
            }
        }

        private void SetEndSequenceFlow(string EventName)
        {
            EndEvent.Name = EventName;
            foreach (var item in Tasks)
            {
                var endSequence = new ProcessSequenceFlow(item.Id, EndEvent.Id);
                item.outgoing = endSequence.Id;
                SequenceFlows.Add(endSequence);
                EndEvent.Incoming.Add(endSequence.Id);
            }
        }
    }
}
