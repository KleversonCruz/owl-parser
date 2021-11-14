using System;
using System.IO;
using System.Xml.Serialization;

namespace OwlParser
{
    public class Parser
    {
        public T LoadDocument<T>(string arquivo) where T : class
        {
            var serialize = new XmlSerializer(typeof(T));
            try
            {
                //var xmlArquivo = System.Xml.XmlReader.Create(arquivo);
                using (TextReader reader = new StringReader(arquivo))
                {
                    return (T)serialize.Deserialize(reader);
                }

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
