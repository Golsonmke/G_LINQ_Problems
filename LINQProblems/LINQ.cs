using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    public class LINQ
    {
        public delegate bool NoDuplicates(string s);
        public delegate bool CheckForTH(string s);
        public List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth",
        "mathmatics" };
        public List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
        public static IEnumerable<string> CheckWords(List<string> words, CheckForTH wordsToCheck)
        {
            
            foreach(var word in words)
            {
                if(wordsToCheck(word))
                {
                    yield return word;

                }

            }

        }
        public static bool Contains(string word)
        {
            return word.Contains("th");
        }
        public static IEnumerable<string> CheckForDuplicates(List<string> names, NoDuplicates noDuplicates)
        {
            foreach (var name in names)
            {
                if (noDuplicates(name))
                {
                    yield return name;
                }
            }
        }
       


    }
}
