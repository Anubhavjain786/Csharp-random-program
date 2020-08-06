using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpRandomProgram
{
    class FibonacciSeries
    {
        public static void code()
        {
            //Enter the number of elements: 15
            //0 1 1 2 3 5 8 13 21 34 55 89 144 233 377
            Rerun:
            long n1=0,n2=1,n3=0,i=0,n=0;
            Console.Write("Enter the number of elements: ");
            n = long.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Error!!...Enter a Positive Number:");
            }
            else
            {
                if (n == 1)
                {
                    Console.WriteLine(n1);
                }
                else
                {
                    if (n == 2)
                    {
                        Console.WriteLine(n1 + " " + n2);
                    }
                    else
                    {
                        Console.Write(n1 + " " + n2);
                        for (i = 2; i < n; ++i)
                        {
                            n3 = n1 + n2;
                            Console.Write(" " + n3);
                            n1 = n2;
                            n2 = n3;
                        }
                    }
                }
            }
            
            Console.Write("Do You Want to Re-Run the Program (y/n): ");
            char flow = Console.ReadLine()[0];
            if (flow=='y'|flow=='Y')
            {
                goto Rerun;
            }
            
        }
    }
}
