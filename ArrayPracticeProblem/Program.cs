namespace ArrayPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRACTICE PROBLEM");
            Console.WriteLine("Select your option \n1.Duplicate Elements \n2.Unique Elements ");
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
                
            }

        }
    }
}