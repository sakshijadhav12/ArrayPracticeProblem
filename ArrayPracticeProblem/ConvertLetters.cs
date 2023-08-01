using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPracticeProblem
{
    internal class ConvertLetters
    {
        public void Convert()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            string capitalizedString = CapitalizeFirstLetter(input);
            Console.WriteLine("Capitalized string: " + capitalizedString);
        }
        static string CapitalizeFirstLetter(string input)
        {
            string[] words = input.Split(' ');
            string capitalizedString = "";

            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    string capitalizedWord = char.ToUpper(word[0]) + word.Substring(1);
                    capitalizedString += capitalizedWord + " ";
                }
            }

            return capitalizedString.Trim();
        }
    }
}
