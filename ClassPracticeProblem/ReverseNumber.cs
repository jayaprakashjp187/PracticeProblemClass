using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPracticeProblem
{
     class ReverseNumber
    {
        public void checkingReverseNumber(int num)
        {
            int rev = 0;
            int ld = 0;
            
            while(num!=0)
            {
                ld = num % 10;
                rev = rev * 10 + ld;
                num = num / 10;
            }
            Console.WriteLine("reverse of the number is "  +rev);
            
                
        }
        

        
    }
}
