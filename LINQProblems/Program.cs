using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
                List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathmatics" };
            IEnumerable<string> result = LINQ.CheckWords(words, LINQ.Contains);

            foreach(string word in result)
            {
                Console.WriteLine(word);
            }
            //**************************************************************************************************************************
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            IEnumerable<string> namesResult = LINQ.CheckForDuplicates(names, LINQ.Contains);
            foreach (string name in namesResult)
            {
                Console.WriteLine(name);
            }
        } 
    }
}
