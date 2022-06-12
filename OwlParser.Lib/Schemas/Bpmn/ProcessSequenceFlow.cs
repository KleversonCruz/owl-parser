using OwlParser.Lib.Schemas.Bpmn.Diagram;
using System;
using System.Xml.Serialization;

namespace OwlParser.Lib.Schemas.Bpmn
{

    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
    public partial class ProcessSequenceFlow : ProcessElementAttributes
    {
        public ProcessSequenceFlow() { }

        public ProcessSequenceFlow(string sourceRef, string targetRef)
        {
            this.sourceRef = sourceRef;
            this.targetRef = targetRef;
        }

        [XmlAttribute()]
        public string sourceRef { get; set; }

        [XmlAttribute()]
        public string targetRef { get; set; }
    }
}
