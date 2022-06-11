using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace OwlParser.App
{
    public class XmlReader
    {
        public static T ReadFile<T>(string pathFile) where T : class
        {
            var fileContent = Encoding.UTF8.GetString(File.ReadAllBytes(pathFile));
            var serialize = new XmlSerializer(typeof(T));
            try
            {
                //var xmlArquivo = System.Xml.XmlReader.Create(arquivo);
                using (TextReader reader = new StringReader(fileContent))
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
