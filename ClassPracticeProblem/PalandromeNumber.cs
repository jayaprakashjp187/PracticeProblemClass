using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPracticeProblem
{
    internal class PalandromeNumber
    {
        public void checkingPalandromeNumber(int num)
        {
            int rev = 0;
            int ld = 0;
            while(num!=0) 
            {
                num= num% 10;
                rev = rev + ld;
                num = num / 10;
            }
            num= rev;
            if(num == rev)
            {
                Console.WriteLine("given the number is palandrome");
            }
            else
            {
                Console.WriteLine("given the number is not a palandrome");
            }

        }
    }
}
