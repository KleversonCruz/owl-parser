namespace OwlParser.Lib.Schemas
{
    public class XmlFile
    {
        public XmlFile(string name, string content)
        {
            Name = name;
            Content = content;
        }

        public string Name { get; set; }
        public string Content { get; set; }
    }
}
