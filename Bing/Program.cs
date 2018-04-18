using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
