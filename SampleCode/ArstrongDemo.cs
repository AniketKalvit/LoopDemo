using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    internal class ArstrongDemo
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write("  ");
                }
                // use for loop where k is less than equal to (2 * i -1)  
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("* "); // print the Star  
                }
                Console.WriteLine();
            }

        }
    }
}
