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
        public List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
        public string teacher = "Terrill";
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
            foreach (var i in duplicateWords)
            {
                Console.WriteLine(i);
            }
            return duplicateWords;
        }
        public static decimal AverageGrades(List<string> input)
        {
            var averageGrades = input.Select(x => x.Split(',').Select(y => Convert.ToDecimal(y)).ToList().OrderByDescending(z => z).Take(4).Average()).Average();
            Console.WriteLine(averageGrades);
            return averageGrades;
            
        }
        public static string ReturnAlphabeticalString(string input)
        {
            
            var findDupes = input.ToList().FindAll(i => i == i);
            Console.WriteLine(userInput);
            return userInput.ToString();
        }
        //public static string ReturnAlphabetically(string input)
        //{
        //    int letterCounter = 0;
        //    string currentLetter = null;
        //    Console.WriteLine("please input string");
        //    input = Console.ReadLine();
        //    for(int i = 0; i > input.Length; i++)
        //    {
        //        if(i.Equals(i))
        //        {
        //            letterCounter++;
        //            currentLetter = i.ToString();

        //        }
        //    }
        //}
    }
}
