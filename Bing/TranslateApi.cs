using System.Collections.Generic;
using RestSharp;

namespace Bing
{
    public class TranslateApi
    {
        private const string ApiUrl = "http://xtk.azurewebsites.net/BingDictService.aspx";

        private readonly RestClient _client;

        /// <summary>
        /// 翻译结果缓存
        /// </summary>
        private readonly Dictionary<string, TranslateResult> _cacheResults;

        public TranslateApi()
        {
            _client = new RestClient(ApiUrl);
            _cacheResults = new Dictionary<string, TranslateResult>();
        }

        /// <summary>
        /// 英翻中
        /// </summary>
        /// <param name="word">要翻译的英文单词</param>
        /// <returns>翻译结果</returns>
        public TranslateResult EnToZh(string word)
        {
            word = word.Trim();

            // 直接返回已查询过的翻译结果
            if (_cacheResults.ContainsKey(word))
            {
                return _cacheResults[word];
            }

            var request = new RestRequest();
            request.AddQueryParameter("Word", word);
            var response = _client.Get<TranslateResult>(request);
            var result = response.Data;

            // 将结果存入缓存
            _cacheResults.Add(word,result);

            return result;
        }
    }
}
