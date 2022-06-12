using System.Text.RegularExpressions;

namespace OwlParser.Lib.Schemas
{
    public class XmlFile
    {
        public XmlFile(string name, string content)
        {
            this.name = name;
            Content = content;
        }

        private string name;

        public string Name
        {
            get
            {
                string withoutSpecialChars = Regex.Replace(name, @"[^0-9a-zA-Z]+", "");
                return $"{withoutSpecialChars}.xml";
            }
            set { name = value; }
        }

        public string Content { get; set; }
    }
}
