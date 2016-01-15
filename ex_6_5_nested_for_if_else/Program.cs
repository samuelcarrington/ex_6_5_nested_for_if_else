using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_6_5_nested_for_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6-5  Write a program that prints the 12 * 12 multiplication table. 
            Print out the table in a matrix like fashion, 
            each number formatted to a width of 4
            (See the Multiplication Tables challenge from codeeval.com)
            */

            int i = 0;
            int j = 0;
            int product = 0;
            for (i = 1; i <= 12; i++)
            {
                for (j = 1; j <= 12; j++)
                {
                    product = i * j;
                    if (j == 1)
                    {
                        Console.Write("{0,2}", product);
                    }
                    else
                    {
                        Console.Write("{0,4}", product);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
