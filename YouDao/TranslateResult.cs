using System.Collections.Generic;

namespace YouDao
{
    public class WebItem
    {
        public List<string> Value { get; set; }

        public string Key { get; set; }
    }

    public class Dict
    {
        public string Url { get; set; }
    }

    public class Webdict
    {
        public string Url { get; set; }
    }

    public class Basic
    {
        /// <summary>
        /// 美式音标
        /// 英文查词成功，一定存在
        /// </summary>
        public string UsPhonetic { get; set; }

        /// <summary>
        /// 默认音标
        /// 默认是英式音标，英文查词成功，一定存在
        /// </summary>
        public string Phonetic { get; set; }

        /// <summary>
        /// 英式音标
        /// 英文查词成功，一定存在
        /// </summary>
        public string UkPhonetic { get; set; }

        /// <summary>
        /// 英式发音
        /// 英文查词成功，一定存在
        /// </summary>
        public string UkSpeech { get; set; }

        /// <summary>
        /// 基本释义
        /// </summary>
        public List<string> Explains { get; set; }

        /// <summary>
        /// 美式发音
        /// 英文查词成功，一定存在
        /// </summary>
        public string UsSpeech { get; set; }
    }

    public class TranslateResult
    {
        /// <summary>
        /// 翻译结果发音地址
        /// 翻译成功一定存在
        /// </summary>
        public string TSpeakUrl { get; set; }

        /// <summary>
        /// 词义
        /// 网络释义，该结果不一定存在
        /// </summary>
        public List<WebItem> Web { get; set; }

        /// <summary>
        /// 源语言
        /// 查询正确时，一定存在
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// 翻译结果
        /// 查询正确时一定存在
        /// </summary>
        public List<string> Translation { get; set; }

        /// <summary>
        /// 错误返回码
        /// 一定存在
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// 词典deeplink
        /// 查询语种为支持语言时，存在
        /// </summary>
        public Dict Dict { get; set; }

        /// <summary>
        /// webdeeplink
        /// 查询语种为支持语言时，存在
        /// </summary>
        public Webdict Webdict { get; set; }

        /// <summary>
        /// 词义
        /// 基本词典,查词时才有
        /// </summary>
        public Basic Basic { get; set; }

        /// <summary>
        /// 源语言和目标语言
        /// 一定存在
        /// </summary>
        public string L { get; set; }

        /// <summary>
        /// 源语言发音地址
        /// 翻译成功一定存在
        /// </summary>
        public string SpeakUrl { get; set; }
    }
}
