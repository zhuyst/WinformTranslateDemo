using RestSharp;

namespace Bing
{
    public class TranslateApi
    {
        private const string ApiUrl = "http://xtk.azurewebsites.net/BingDictService.aspx";

        private readonly RestClient _client;

        public TranslateApi()
        {
            _client = new RestClient(ApiUrl);
        }

        /// <summary>
        /// 英翻中
        /// </summary>
        /// <param name="word">要翻译的英文单词</param>
        /// <returns>翻译结果</returns>
        public TranslateResult EnToZh(string word)
        {
            var request = new RestRequest();
            request.AddQueryParameter("Word", word);
            var response = _client.Get<TranslateResult>(request);
            return response.Data;
        }
    }
}
