using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRandomProgram
{
    class ArmstrongNumber
    {
        public static void code()
        {
            int num, arm=0, temp;
            Console.Write("Enter The Number: ");
            num = int.Parse(Console.ReadLine());
            temp = num;
            while (num>0)
            {
                arm = arm + ((num % 10) * (num % 10) * (num % 10));
                num = num / 10;
            }

            if (temp==arm)
            {
                Console.WriteLine("The Number {0} is Armstrong Number",temp);
            }
            else
            {
                Console.WriteLine("The Number {0} is not Armstrong Number", temp);
            }

            Console.ReadKey();
        }
    }
}
