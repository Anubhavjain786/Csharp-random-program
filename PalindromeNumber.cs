using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRandomProgram
{
    class PalindromeNumber
    {
        public static void code()
        {
            int num, rev=0,temp;
            Console.Write("Enter The Number: ");
            num = int.Parse(Console.ReadLine());
            temp = num;
            while (temp>0)
            {
                rev = (rev * 10) + (temp % 10);
                temp = temp / 10;
            }

            if (rev == num)
            {
                Console.WriteLine("Number Is Palindrome");
            }
            else
            {
                Console.WriteLine("Number Is not Palindrome");
            }

            Console.ReadKey();
        }
    }
}
