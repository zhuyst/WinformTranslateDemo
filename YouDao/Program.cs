using Newtonsoft.Json;
using System.Diagnostics;

namespace YouDao
{
    static class Program
    {
        static void Main()
        {
            TranslateApi api = new TranslateApi();
            var result = api.EnToZh("good");
            var str = JsonConvert.SerializeObject(result);
            Debug.WriteLine(str);
        }
    }
}