using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayPracticeProblem
{
    class MinAndMax
    {
        public void FindMinMax()
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

            foreach (var kvp in frequencyMap)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

          
            int max = arr[0];
            int min = arr[0];

            foreach (int element in arr)
            {
                if (element > max)
                    max = element;

                if (element < min)
                    min = element;
            }

            Console.WriteLine($"Maximum element in the array: {max}");
            Console.WriteLine($"Minimum element in the array: {min}");
        }
    }
}
