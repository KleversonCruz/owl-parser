using System;
using System.Xml.Serialization;

namespace OwlParser.Lib.Schemas.Bpmn
{
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
    public partial class ProcessTask : ProcessElementAttributes
    {
        public ProcessTask()
        {

        }
        public ProcessTask(string name)
        {
            Name = name;
        }
        public string outgoing { get; set; }
        public string incoming { get; set; }
    }
}
