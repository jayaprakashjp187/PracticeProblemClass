using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPracticeProblem
{
    class PrimeNumber
    {
        public void checkingPrimeNumber(int n)
        {
            int count = 0;
            for(int i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    count++;

                }
               
            }
            if(count==2)
            {
                Console.WriteLine("the number is prime");
            }
            else
            {
                Console.WriteLine("the number is not a prime");
            }
        }
    }
}
