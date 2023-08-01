using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPracticeProblem
{
    internal class SumOfGivenNumbers
    { public void SumOfDigits()
        {
           int sum = 0, b;
            Console.WriteLine("enter a Digit");
            int a =Convert.ToInt32(Console.ReadLine());

            while (a != 0)
            {
                b = a % 10; 
                sum = sum + b; 
                a = a / 10; 
            }
            Console.WriteLine("The sum of the digits is: " + sum);
        }
    }
}
