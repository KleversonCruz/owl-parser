using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace OwlParser.Lib
{
    internal class XmlUtil
    {
        public static T DeserializeString<T>(string xmlString) where T : class
        {
            try
            {
                XmlSerializer serialize = new(typeof(T));
                using TextReader reader = new StringReader(xmlString);
                return (T)serialize.Deserialize(reader);
            }
            catch (Exception ex)
            {
                throw new Exception($"Houve um erro ao carregar o XML: {ex.Message}");
            }
        }

        public static string SerializeObject<T>(T toSerialize) where T : class
        {
            try
            {
                XmlSerializer xmlSerializer = new(toSerialize.GetType());
                using StringWriterWithEncoding textWriter = new(Encoding.UTF8);
                xmlSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception($"Houve um erro ao gerar XML: {ex.Message}");
            }
        }

        private sealed class StringWriterWithEncoding : StringWriter
        {
            public override Encoding Encoding { get; }
            public StringWriterWithEncoding(Encoding encoding)
            {
                Encoding = encoding;
            }
        }
    }
}
