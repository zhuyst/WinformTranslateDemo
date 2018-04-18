using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouDao
{
    public class WebItem
    {
        /// <summary>
        /// 
        /// </summary>
        public List<string> Value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Key { get; set; }
    }

    public class Dict
    {
        /// <summary>
        /// 
        /// </summary>
        public string Url { get; set; }
    }

    public class Webdict
    {
        /// <summary>
        /// 
        /// </summary>
        public string Url { get; set; }
    }

    public class Basic
    {
        /// <summary>
        /// 
        /// </summary>
        public string UsPhonetic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Phonetic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UkPhonetic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UkSpeech { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> Explains { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UsSpeech { get; set; }
    }

    public class TranslateResult
    {
        /// <summary>
        /// 
        /// </summary>
        public string TSpeakUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<WebItem> Web { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Query { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> Translation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ErrorCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dict Dict { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Webdict Webdict { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Basic Basic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string L { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SpeakUrl { get; set; }
    }
}
