using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class Practice
    {
        public void ReturnWordsThatContain()
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordsThatContainTh = words.Where(w => w.Contains("th")).ToList();
            foreach (var word in wordsThatContainTh)
            {
                Console.WriteLine(word);
            }
        }

        public void ReturnListWithNoDuplicates()
        {
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var namesWithNoDuplicates = names.Distinct().ToList();
            foreach (var name in namesWithNoDuplicates)
            {
                Console.WriteLine(name);
            }
        }

    }
}
