using OwlParser.Lib.Schemas.Bpmn;
using OwlParser.Lib.Schemas.Bpmn.Diagram;
using System.Collections.Generic;

namespace OwlParser.Lib
{
    internal class DiagramBuilder
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
            Shape shape = new(process.Id);
            shape.Bounds = new(30, 30, 700, 350);
            Shapes.Add(shape);
            return this;
        }

        public DiagramBuilder WithTasks(List<ProcessTask> processTask)
        {
            for (int i = 0; i < processTask.Count; i++)
            {
                Shape shape = new(processTask[i].Id);
                shape.Bounds = new(Grid.CenterMiddle.X, Grid.CenterMiddle.Y + (i * 65), 90, 60);
                Shapes.Add(shape);
            }
            return this;
        }

        public DiagramBuilder WithEvent(ProcessStartEvent startEvent)
        {
            Shape shape = new(startEvent.Id);
            shape.Bounds = new(Grid.LeftMiddle.X, Grid.LeftMiddle.Y, 30, 30);
            Shapes.Add(shape);
            return this;
        }

        public DiagramBuilder WithEvent(ProcessEndEvent endEvent)
        {
            Shape shape = new(endEvent.Id);
            shape.Bounds = new(Grid.RightMiddle.X, Grid.RightMiddle.Y, 30, 30);
            Shapes.Add(shape);
            return this;
        }

        public DiagramBuilder WithSequenceFlows(List<ProcessSequenceFlow> sequenceFlows)
        {
            foreach (var sequence in sequenceFlows)
            {
                Edge edge = new(sequence.Id);
                edge.Waypoint.Add(new Waypoint(Grid.LeftMiddle.X, Grid.LeftMiddle.Y));
                edge.Waypoint.Add(new Waypoint(Grid.CenterMiddle.X, Grid.CenterMiddle.Y));
                Edges.Add(edge);
            }
            return this;
        }
    }
}
