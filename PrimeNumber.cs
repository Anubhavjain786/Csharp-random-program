using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRandomProgram
{
    class PrimeNumber
    {
        public static void code()
        {
            int i,j,num,flag=0;
            
            Console.Write("Enter The Number Which Is Want To Check: ");
            num = int.Parse(Console.ReadLine());
            j = num / 2;
            for (i = 2; i <= j; i++)
            {
                if (num % i == 0)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag==0)
            {
                Console.WriteLine("This is Prime Number: "+num);
            }
            else
            {
                Console.WriteLine("This is Not a Prime Number");
            }

            Console.ReadKey();
        }
    }
}
