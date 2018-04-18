using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;

namespace Words
{
    public class Words
    {
        private const string FileName = "words";

        private static List<string> _words;

        public static List<string> GetWords()
        {
            if (_words != null)
            {
                return _words;
            }

            var str = ReadFile();
            _words = str.Split(',').ToList();
            return _words;
        }

        private static string ReadFile()
        {
            var assembly = Assembly.GetEntryAssembly();
            var manager = new ResourceManager("Words.Properties.Resources", assembly);
            return manager.GetString(FileName);
        }
    }
}
