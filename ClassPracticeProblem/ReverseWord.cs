using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPracticeProblem
{
    internal class ReverseWord
    {
        public static void CheckingReverseWord(String word)
        {
            String rev = "";
            foreach (char c in word)
            {
                rev = c + rev;
            }
             Console.WriteLine(rev);

        }
        
    }
}
