using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPracticeProblem
{
    internal class ReverseString
    {  public void Reverse()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            string reversedString = ReverseEachWord(input);
            Console.WriteLine("Reversed string: " + reversedString);
        }

        static string ReverseEachWord(string input)
        {
            string[] words = input.Split(' ');
            string reversedString = "";

            foreach (string word in words)
            {
                char[] chars = word.ToCharArray();
                Array.Reverse(chars);
                reversedString += new string(chars) + " ";
            }

            return reversedString.Trim();
        }
    }

}

