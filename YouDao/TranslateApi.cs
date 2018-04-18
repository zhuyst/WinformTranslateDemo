using RestSharp;
using System;
using System.Security.Cryptography;
using System.Text;

namespace YouDao
{
    public class TranslateApi
    {
        private const string AppKey = "7517e3e1d7c42033";

        private const string AppSecret = "tl6RlC0bKr1VcTld7EMTtPQoVIOMOWfM";

        private const string ApiUrl = "https://openapi.youdao.com/";

        private readonly RestClient _client;

        public TranslateApi()
        {
            _client = new RestClient(ApiUrl);
        }

        public TranslateResult EnToZh(string q)
        {
            const string from = "en";
            const string to = "zh-CHS";

            var salt = GetSalt();
            var sign = GetSign(q, salt);

            var request = new RestRequest("api");
            request.AddParameter("q", q);
            request.AddParameter("from", from);
            request.AddParameter("to", to);
            request.AddParameter("appKey", AppKey);
            request.AddParameter("salt", salt);
            request.AddParameter("sign", sign);

            var response = _client.Post<TranslateResult>(request);
            return response.Data;
        }

        private static string GetSalt()
        {
            return Guid.NewGuid().ToString();
        }

        private static string GetSign(string q, string salt)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            var md5Str = AppKey + q + salt + AppSecret;
            var output = md5.ComputeHash(Encoding.UTF8.GetBytes(md5Str));
            return BitConverter.ToString(output).Replace("-", "");
        }
    }
}
