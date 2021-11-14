using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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
