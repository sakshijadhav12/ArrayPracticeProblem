namespace ArrayPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRACTICE PROBLEM");
            Console.WriteLine("Select your option \n1.Duplicate Elements \n2.Unique Elements \n3.FrequencyElements \n4.MinAndMax \n5.Print Design \n6.Print Design two \n7.Sum of given Numbers \n8.Sum of Lowest \n9.Reverse String ");
            int option = int.Parse(Console.ReadLine()); 
            switch(option)
            {
                case 1:
                    Duplicate_Elements ob = new Duplicate_Elements();
                    ob.CountDuplicateElements(); 
                    break;
                case 2:
                    UniqueElements uniqueElements = new UniqueElements();
                    uniqueElements.PrintUniqueElements();
                  break;
                case 3:
                   FrequencyElements frequencyElements = new FrequencyElements ();
                    frequencyElements.Countfrequency();
                    break;
                case 4:
                   MinAndMax minAndMax = new MinAndMax ();
                    minAndMax.FindMinMax();
                    break;
                case 5:
                    PrintDesign printDesign = new PrintDesign ();
                    printDesign.Design();
                break;
            case 6:
                    Print print = new Print();
                    print.PrintDesign();
                    break;
               case 7:
                    SumOfGivenNumbers sumOfGivenNumbers  = new SumOfGivenNumbers();
                    sumOfGivenNumbers.SumOfDigits();
                    break;
            case 8:
                    SumOfLowest sumOfLowest = new SumOfLowest();
                    sumOfLowest.SumOfLowestNumber();
                    break;
             case 9:
                    ReverseString reverseString = new ReverseString();
                    reverseString.Reverse();
                    break;


            }

        }
    }
}