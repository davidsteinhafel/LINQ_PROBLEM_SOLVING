using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    public class Word_Library
    {
        public List<Word> GetWords()
        {
            return new List<Word>()
            {
                new Word() {word = "the"},
                new Word() {word = "bike"},
                new Word() {word = "this"},
                new Word() {word = "it"},
                new Word() {word = "tenth"},
                new Word() {word = "mathematics"}
            };
        }
    }
}
