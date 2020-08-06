using System;

namespace CSharpRandomProgram
{
    class Factorial
    {
        public static void code()
        {
            Console.Write("Enter the Number: ");
            long num = int.Parse(Console.ReadLine());
            long fact=1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of {0} is {1}",num,fact);
            Console.ReadKey();
        }
    }
}
    