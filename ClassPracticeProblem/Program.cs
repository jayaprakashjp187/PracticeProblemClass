namespace ClassPracticeProblem
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please choose what program u want");
            Console.WriteLine("1.welcome message\n2.calculator program\n3.ReverseNumber\n4.PalandromeProgram\n5.PrimeNumberProgram");
            int choose =Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("welcome to the practice problem");
                    break;
                case 2:
                    Console.WriteLine("welcome to the calculator program");
                    Console.WriteLine("enter 1 st number");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter 2 nd number");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    CalculatorProgram jp = new CalculatorProgram();
                    jp.addTwoNumbers(num1, num2);
                    jp.subTwoNumbers(num1, num2);
                    jp.multiplyTwoNumbers(num1, num2);
                    jp.remainderOfTwoNumbers(num1, num2);
                    jp.quotientOfTwoNumbers(num1, num2);
                    break;

                case 3:
                
                    Console.WriteLine("welcome to the reverse program");
                    Console.WriteLine("enter the number for checking either reverse or not");
                    int num=Convert.ToInt32(Console.ReadLine());
                    ReverseNumber j = new ReverseNumber();
                    j.checkingReverseNumber(num);
                    break;
                case 4:
                    Console.WriteLine("welcome to the palandrome program");
                    Console.WriteLine("enter the number for checking palandrome number or not");
                    int number=Convert.ToInt32(Console.ReadLine());
                    PalandromeNumber p = new PalandromeNumber();
                    p.checkingPalandromeNumber(number);
                    break;
                case 5:
                    Console.WriteLine("welcome to the prime number program");
                    Console.WriteLine("enter the number checking whether the number is prime or not");
                    int n= Convert.ToInt32(Console.ReadLine());
                    PrimeNumber k= new PrimeNumber();
                    k.checkingPrimeNumber(n);
                    break;




                 


                

            }


        }
    }
}