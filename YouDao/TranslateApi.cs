using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace YouDao
{
    public class TranslateApi
    {
        private static readonly string APP_KEY = "7517e3e1d7c42033";

        private static readonly string APP_SECRET = "tl6RlC0bKr1VcTld7EMTtPQoVIOMOWfM";

        private static readonly string API_URL = "https://openapi.youdao.com/";

        private RestClient _client;

        public TranslateApi()
        {
            _client = new RestClient(API_URL);
        }

        public TranslateResult EnToZh(string q)
        {
            var from = "en";
            var to = "zh-CHS";
            var salt = Guid.NewGuid().ToString();

            MD5 md5 = new MD5CryptoServiceProvider();
            var md5Str = APP_KEY + q + salt + APP_SECRET;
            byte[] output = md5.ComputeHash(Encoding.UTF8.GetBytes(md5Str));
            var sign = BitConverter.ToString(output).Replace("-", "");

            var request = new RestRequest("api");
            request.AddParameter("q", q);
            request.AddParameter("from", from);
            request.AddParameter("to", to);
            request.AddParameter("appKey", APP_KEY);
            request.AddParameter("salt", salt);
            request.AddParameter("sign", sign);

            var response = _client.Post<TranslateResult>(request);
            return response.Data;
        }
    }
}
