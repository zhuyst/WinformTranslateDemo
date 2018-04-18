using System.Collections.Generic;

namespace Bing
{
    public class Pronunciation
    {
        /// <summary>
        /// 美国音标
        /// </summary>
        public string AmE { get; set; }

        /// <summary>
        /// 美国音标URL
        /// </summary>
        public string AmEmp3 { get; set; }

        /// <summary>
        /// 英国音标
        /// </summary>
        public string BrE { get; set; }

        /// <summary>
        /// 英国音标URL
        /// </summary>
        public string BrEmp3 { get; set; }
    }

    public class DefsItem
    {
        /// <summary>
        /// 词性
        /// </summary>
        public string Pos { get; set; }

        /// <summary>
        /// 词义
        /// </summary>
        public string Def { get; set; }
    }

    public class SamsItem
    {
        /// <summary>
        /// 英语原句
        /// </summary>
        public string Eng { get; set; }

        /// <summary>
        /// 中文翻译
        /// </summary>
        public string Chn { get; set; }

        /// <summary>
        /// 英语发音URL
        /// </summary>
        public string Mp3Url { get; set; }
    }

    public class TranslateResult
    {
        /// <summary>
        /// 查询单词
        /// </summary>
        public string Word { get; set; }

        /// <summary>
        /// 音标
        /// </summary>
        public Pronunciation Pronunciation { get; set; }

        /// <summary>
        /// 词义
        /// </summary>
        public List<DefsItem> Defs { get; set; }

        /// <summary>
        /// 例句
        /// </summary>
        public List<SamsItem> Sams { get; set; }
    }
}
