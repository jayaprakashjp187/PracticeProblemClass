using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPracticeProblem
{
    internal class PrimeNumberRange
    {
        public void checkingPrimeNumber(int maxNum)
        {
            int count = 0;
            for (int i = 1; i <=  maxNum; i++)
            {
                 count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if(i%j ==0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine("prime number in the range of max number is " +i);
                }
            }
           
        }
    }
}
