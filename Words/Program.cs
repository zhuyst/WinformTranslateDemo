using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words
{
    static class Program
    {
        static void Main()
        {
            var list = Words.GetWords();
            foreach (var word in list)
            {
                Debug.WriteLine(word);
            }
        }
    }
}
