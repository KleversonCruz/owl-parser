using OwlParser.App.Schemas.Bpmn;
using OwlParser.App.Schemas.Bpmn.Diagram;
using System.Collections.Generic;

namespace OwlParser.App
{
    public class DiagramBuilder
    {
        private DocumentDiagram diagram = new();
        private List<Edge> Edges = new();
        private List<Shape> Shapes = new();
        public DocumentDiagram Build()
        {
            diagram.BPMNPlane.BPMNShapes.AddRange(Shapes);
            diagram.BPMNPlane.BPMNEdges.AddRange(Edges);
            return diagram;
        }

        public DiagramBuilder WithProcess(Process process)
        {
            diagram.BPMNPlane = new()
            {
                BpmnElement = process.Id,
            };
            return this;
        }

        public DiagramBuilder WithTasks(List<ProcessTask> processTask)
        {
            foreach (var task in processTask)
            {
                Shape shape = new(task.Id);
                shape.Bounds = new("309", "158", "90", "60");
                Shapes.Add(shape);
            }
            return this;
        }

        public DiagramBuilder WithEvent(ProcessStartEvent startEvent)
        {
            Shape shape = new(startEvent.Id);
            shape.Bounds = new("95", "173", "30", "30");
            Shapes.Add(shape);
            return this;
        }

        public DiagramBuilder WithEvent(ProcessEndEvent endEvent)
        {
            Shape shape = new(endEvent.Id);
            shape.Bounds = new("95", "173", "30", "30");
            Shapes.Add(shape);
            return this;
        }

        public DiagramBuilder WithSequenceFlows(List<ProcessSequenceFlow> sequenceFlows)
        {
            foreach (var sequence in sequenceFlows)
            {
                Edge edge = new(sequence.Id);
                edge.Waypoint.Add(new Waypoint("399", "279"));
                edge.Waypoint.Add(new Waypoint("546", "279"));
                edge.Waypoint.Add(new Waypoint("546", "188"));
                edge.Waypoint.Add(new Waypoint("608", "188"));
                Edges.Add(edge);
            }
            return this;
        }
    }
}
