using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPracticeProblem
{
    internal class Fibonacci
    {
        public static void CheckingFibonacci(int n) 
        {
            int a=0; int b=1; int c = 0;
            for(int i=1; i<=n; i++)
            {
                Console.Write( c);
                a = b;
                b=c;
                c = a + b;
                Console.Write( "  ");
               
            }
            

        }
    }
}
