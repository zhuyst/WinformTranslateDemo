using System.Collections.Generic;
using System.Linq;
using System.Resources;
using Words.Properties;

namespace Words
{
    public class Words
    {
        /// <summary>
        /// 单词资源名
        /// </summary>
        private const string ResourceName = "words";

        /// <summary>
        /// 单词列表
        /// </summary>
        private static List<string> _words;

        /// <summary>
        /// 获取单词列表
        /// </summary>
        /// <returns>单词列表</returns>
        public static List<string> GetWords()
        {
            if (_words != null)
            {
                return _words;
            }

            var str = ReadFile();

            // 以,作为分隔符获取单词
            _words = str.Split(',').ToList();
            return _words;
        }

        /// <summary>
        /// 读取包含单词的txt文件
        /// </summary>
        /// <returns>整个txt文件的字符串</returns>
        private static string ReadFile()
        {
            var manager = new ResourceManager("Words.Properties.Resources", typeof(Resources).Assembly);
            return manager.GetString(ResourceName);
        }
    }
}
