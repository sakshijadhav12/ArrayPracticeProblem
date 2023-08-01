using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPracticeProblem
{
    internal class SumOfLowest
    {  public void SumOfLowestNumber()
        {
            int[] numbers = { 7, 3, 9, 1, 5, 4, 6, 10 };
            int[] lowestTwoNumbers = FindTwoLowestNumbers(numbers);

            Console.WriteLine("Two lowest numbers are: {0} and {1}", lowestTwoNumbers[0], lowestTwoNumbers[1]);

            int sum = lowestTwoNumbers[0] + lowestTwoNumbers[1];
            Console.WriteLine("Sum of the two lowest numbers: {0}", sum);
        }

        static int[] FindTwoLowestNumbers(int[] numbers)
        {
            if (numbers.Length < 2)
            {
                throw new ArgumentException("The input array should have at least two elements.");
            }

          
            int lowest1 = int.MaxValue;
            int lowest2 = int.MaxValue;

            foreach (int num in numbers)
            {
                if (num < lowest1)
                {
                    lowest2 = lowest1;
                    lowest1 = num;
                }
                else if (num < lowest2)
                {
                    lowest2 = num;
                }
            }

            return new int[] { lowest1, lowest2 };
        }
    }
}
    

