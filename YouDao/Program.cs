using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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