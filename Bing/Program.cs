using Newtonsoft.Json;
using System.Diagnostics;

namespace Bing
{
    static class Program
    {
        static void Main()
        {
            TranslateApi api = new TranslateApi();
            var result = api.EnToZh("nice");
            var str = JsonConvert.SerializeObject(result);
            Debug.WriteLine(str);
        }
    }
}
