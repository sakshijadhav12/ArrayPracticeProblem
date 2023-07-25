using System;

namespace ArrayPracticeProblem
{
    internal class Duplicate_Elements
    {
        public void CountDuplicateElements()
        {
            Console.WriteLine("Enter how many elements you want to store in the array:");
            int num = Convert.ToInt32(Console.ReadLine());
            int j;
            int ctr = 0;
            int[] arr = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < num; i++)
            {
                for (j = i + 1; j < num; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        ctr++;
                        break; // Add this to avoid counting the same duplicate multiple times
                    }
                }
            }

            Console.WriteLine($"{ctr} duplicates found.");
        }
    }
}
