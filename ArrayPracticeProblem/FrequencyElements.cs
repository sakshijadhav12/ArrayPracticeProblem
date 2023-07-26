using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPracticeProblem
{
    internal class FrequencyElements
    {
        public void Countfrequency()

        {
            Console.WriteLine("Enter how many elements you want to store in the array:");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int elements in arr)
            {
                if (frequencyMap.ContainsKey(elements))
                    frequencyMap[elements]++;
                else
                    frequencyMap[elements] = 1;
            }
            Console.WriteLine("Frequency of each element in the array:");
            foreach (var kvp in frequencyMap)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }

}

    

