using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    public class Simulation
    {
        public List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        public static List<string> WordsWithTH(List<string> input)
        {

            var wordsWithTh = input.FindAll(i => i.Contains("th")).ToList();
            
            foreach (var i in wordsWithTh)
            {
                Console.WriteLine(i);
            }
            return wordsWithTh;
        }
    }
}
