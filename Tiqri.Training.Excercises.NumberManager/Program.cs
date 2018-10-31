using System;

namespace Tiqri.Training.Excercises.NumberManager
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileManager fileManager = new FileManager();
                SortManager sortManager = new SortManager(fileManager);

                var sortedNumbers = sortManager.Sort("inputNumbers.csv");

                Console.WriteLine("Sorted Numbers are ......");
                foreach (var number in sortedNumbers)
                {
                    Console.WriteLine(number);
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured,Failed to sort numbers");
                Console.WriteLine(e);
            }
        }
    }
}
