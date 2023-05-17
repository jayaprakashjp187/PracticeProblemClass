using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPracticeProblem
{
    internal class Array
    {
        public static void StoringOfArrayNumbers(int num) 
        {
            Console.WriteLine("enter the numbers");
            int[] arr=new int[num];
            for (int i = 0; i < num; i++) 
            {
                Console.WriteLine("please enter the " +(i+1) + "value");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
