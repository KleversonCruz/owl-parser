using OwlParser.App.Schemas.Bpmn.Diagram;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace OwlParser.App.Schemas.Bpmn
{
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
    [XmlRoot("definitions", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable = false)]
    public partial class RootDefinitions
    {
        public RootDefinitions() { }

        public RootDefinitions(List<Process> process, DocumentDiagram diagram)
        {
            id = Guid.NewGuid().ToString();
            this.process = process;
            BPMNDiagram = diagram;
        }

        [XmlElement("process")]
        public List<Process> process { get; set; }

        [XmlAttribute()]
        public string id { get; set; }

        [XmlElement(Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
        public DocumentDiagram BPMNDiagram { get; set; }

    }
}
