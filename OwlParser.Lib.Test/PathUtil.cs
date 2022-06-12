using System.IO;
using System.Reflection;

namespace OwlParser.Lib.Test
{
    internal static class PathUtil
    {
        public static string DirectoryPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        public static string GetFileInBpmnPath(string fileName)
        {
            return Path.Combine(DirectoryPath, "Files", "BPMN", fileName);
        }

        public static string GetFileInOwlPath(string fileName)
        {
            return Path.Combine(DirectoryPath, "Files", "OWL", fileName);
        }
    }
}
