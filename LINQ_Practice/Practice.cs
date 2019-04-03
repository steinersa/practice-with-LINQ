using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class Practice
    {
        public void WordsThatContain()
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordsThatContainTh = words.Where(w => w.Contains("th")).ToList();
            foreach (var word in wordsThatContainTh)
            {
                Console.WriteLine(word);
            }
        }

        public void ListWithNoDuplicates()
        {
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var namesWithNoDuplicates = names.Distinct().ToList();
            foreach (var name in namesWithNoDuplicates)
            {
                Console.WriteLine(name);
            }
        }

        //public void CalculateClassAverage()
        //{
        //    List<string> grades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
        //    foreach (var grade in grades)
        //    {
        //        string[] separateTestGrades = grade.Split(',').
        //        droplowest.average.average
        //    }
        //}

        public void LetterFrequencyAlphabeticallyOrdered()
        {
            string name = "Terrill";
            var orderedArray = name.ToLower().ToArray().OrderBy(a => a).GroupBy(a => a).Select(a => new { a.Key, Count = a.Count() });
            var keys = orderedArray.Select(a => a.Key).ToArray();
            var values = orderedArray.Select(a => a.Count).ToArray();
            string[] pairs = new string[10];
            for (int i = 0, j = 0, k = 0; k < 5; i++)
            {
                if (i % 2 == 0)
                {
                    pairs[i] = keys[j];
                    j++;
                }
                if (i % 2 != 0)
                {
                    pairs[i] = values[k];
                    k++;
                }
            }

            //var pairs = keys.Zip(values, (k, v) => new { Keys = k, Values = v });
            //foreach (var kv in pairs)
            //{
            //    Console.WriteLine(kv.Keys + kv.Values);
            //}
            //keys.Zip(values, (a, b) => (a + b));
            //var result = string.Join("", pairs);
            Console.WriteLine(pairs);
            Console.ReadKey();
        }
    }
}
