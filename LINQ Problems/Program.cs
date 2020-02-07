using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Simulation start = new Simulation();
            Simulation.WordsWithTH(start.words);
            Simulation.DuplicateWords(start.names);
            Console.ReadLine();
        }
    }
}
