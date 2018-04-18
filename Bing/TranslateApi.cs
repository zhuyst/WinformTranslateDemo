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

        public TranslateResult EnToZh(string word)
        {
            var request = new RestRequest();
            request.AddQueryParameter("Word", word);
            var response = _client.Get<TranslateResult>(request);
            return response.Data;
        }
    }
}
