using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPracticeProblem
{
    class CalculatorProgram
    {
        public void addTwoNumbers(int num1, int num2) 
        {
           
            int sum=num1 + num2;
            Console.WriteLine("sum of two numbers is" +sum);

        }
        public void subTwoNumbers(int num1, int num2)
        {

            int sub = num1 - num2;
            Console.WriteLine("sub of two numbers is" + sub);

        }
        public void multiplyTwoNumbers(int num1, int num2)
        {

            int multiply = num1 * num2;
            Console.WriteLine("multiplying of two numbers is" + multiply);

        }
        public void remainderOfTwoNumbers(int num1, int num2)
        {

            int remainder = num1 % num2;
            Console.WriteLine("Remainder of two numbers is" + remainder);

        }
        public void quotientOfTwoNumbers(int num1, int num2)
        {

            int quotient = num1 / num2;
            Console.WriteLine("quotients of two numbers is" + quotient);

        }
    }
}
