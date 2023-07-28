using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPracticeProblem
{
    internal class Print
    {
        public void PrintDesign()
        {
            int n = 7; // Number of rows in the pattern
            int m = 7; // Number of columns in the pattern

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == m)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}