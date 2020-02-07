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
        public List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
        public static List<string> WordsWithTH(List<string> input)
        {

            var wordsWithTh = input.FindAll(i => i.Contains("th")).ToList();
            
            foreach (var i in wordsWithTh)
            {
                Console.WriteLine(i);
            }
            return wordsWithTh;
        }
        public static List<string> DuplicateWords(List<string> Input)
        {
            var duplicateWords = Input.FindAll(i => i.Contains(i)).Distinct().ToList();
            foreach(var i in duplicateWords)
            {
                Console.WriteLine(i);
            }
            return duplicateWords;
        }
    }
}
