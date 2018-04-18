using System.Diagnostics;

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
