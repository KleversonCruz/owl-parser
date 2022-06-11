//using System.Collections.Generic;
//using System.Xml.Serialization;

//namespace OwlParser.App.Schemas.Bpmn
//{

//    [System.Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
//    [XmlRoot("BPMNDiagram", Namespace = "http://www.omg.org/spec/BPMN/20100524/DI", IsNullable = false)]
//    public partial class DocumentDiagram
//    {

//        public BPMNDiagramBPMNPlane BPMNPlane { get; set; }


//        [XmlElement("BPMNLabelStyle")]
//        public BPMNDiagramBPMNLabelStyle[] BPMNLabelStyle { get; set; }


//        [XmlAttribute()]
//        public string id { get; set; }
//    }


//    [System.Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
//    public partial class BPMNDiagramBPMNPlane
//    {

//        [XmlAttribute(Namespace = "http://www.omg.org/spec/DD/20100524/DI")]
//        public string extension { get; set; }


//        [XmlElement("BPMNShape")]
//        public List<BPMNDiagramBPMNPlaneBPMNShape> BPMNShape { get; set; }


//        [XmlElement("BPMNEdge")]
//        public BPMNDiagramBPMNPlaneBPMNEdge[] BPMNEdge { get; set; }


//        [XmlAttribute()]
//        public string id { get; set; }


//        [XmlAttribute()]
//        public string bpmnElement { get; set; }
//    }


//    [System.Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
//    public partial class BPMNDiagramBPMNPlaneBPMNShape
//    {


//        [XmlAttribute(Namespace = "http://www.omg.org/spec/DD/20100524/DI")]
//        public string extension { get; set; }


//        [XmlElement(Namespace = "http://www.omg.org/spec/DD/20100524/DC")]
//        public Bounds Bounds { get; set; }


//        public BPMNDiagramBPMNPlaneBPMNShapeBPMNLabel BPMNLabel { get; set; }


//        [XmlAttribute()]
//        public string id { get; set; }


//        [XmlAttribute()]
//        public string bpmnElement { get; set; }


//        [XmlAttribute()]
//        public bool isHorizontal { get; set; }


//        [XmlIgnore()]
//        public bool isHorizontalSpecified { get; set; }
//    }


//    [System.Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/DD/20100524/DC")]
//    [XmlRoot(Namespace = "http://www.omg.org/spec/DD/20100524/DC", IsNullable = false)]
//    public partial class Bounds
//    {


//        [XmlAttribute()]
//        public string x { get; set; }


//        [XmlAttribute()]
//        public string y { get; set; }


//        [XmlAttribute()]
//        public string width { get; set; }


//        [XmlAttribute()]
//        public string height { get; set; }
//    }


//    [System.Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
//    public partial class BPMNDiagramBPMNPlaneBPMNShapeBPMNLabel
//    {



//        [XmlAttribute(Namespace = "http://www.omg.org/spec/DD/20100524/DI")]
//        public string extension { get; set; }


//        [XmlElement(Namespace = "http://www.omg.org/spec/DD/20100524/DC")]
//        public Bounds Bounds { get; set; }


//        [XmlAttribute()]
//        public string id { get; set; }


//        [XmlAttribute()]
//        public string labelStyle { get; set; }
//    }


//    [System.Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
//    public partial class BPMNDiagramBPMNPlaneBPMNEdge
//    {


//        [XmlAttribute(Namespace = "http://www.omg.org/spec/DD/20100524/DI")]
//        public string extension { get; set; }


//        [XmlElement("waypoint", Namespace = "http://www.omg.org/spec/DD/20100524/DI")]
//        public waypoint[] waypoint { get; set; }


//        [XmlAttribute()]
//        public string id { get; set; }


//        [XmlAttribute()]
//        public string bpmnElement { get; set; }
//    }


//    [System.Serializable()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/DD/20100524/DI")]
//    [XmlRoot(Namespace = "http://www.omg.org/spec/DD/20100524/DI", IsNullable = false)]
//    public partial class waypoint
//    {


//        [XmlAttribute()]
//        public string x { get; set; }


//        [XmlAttribute()]
//        public string y { get; set; }
//    }


//    [System.Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
//    public partial class BPMNDiagramBPMNLabelStyle
//    {


//        [XmlElement(Namespace = "http://www.omg.org/spec/DD/20100524/DC")]
//        public Font Font { get; set; }


//        [XmlAttribute()]
//        public string id { get; set; }
//    }


//    [System.Serializable()]
//    [System.ComponentModel.DesignerCategory("code")]
//    [XmlType(AnonymousType = true, Namespace = "http://www.omg.org/spec/DD/20100524/DC")]
//    [XmlRoot(Namespace = "http://www.omg.org/spec/DD/20100524/DC", IsNullable = false)]
//    public partial class Font
//    {

//        [XmlAttribute()]
//        public string name { get; set; }


//        [XmlAttribute()]
//        public byte size { get; set; }


//        [XmlAttribute()]
//        public bool isBold { get; set; }


//        [XmlAttribute()]
//        public bool isItalic { get; set; }


//        [XmlAttribute()]
//        public bool isUnderline { get; set; }


//        [XmlAttribute()]
//        public bool isStrikeThrough { get; set; }
//    }


//}
