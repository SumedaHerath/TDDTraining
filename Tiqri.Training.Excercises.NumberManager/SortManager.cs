using System;
using System.Collections.Generic;

namespace Tiqri.Training.Excercises.NumberManager
{
    public class SortManager : ISortManager
    {
        private readonly IFileManager _fileManager;

        public SortManager(IFileManager fileManager)
        {
            if (fileManager == null) throw new ArgumentNullException(nameof(fileManager));

            _fileManager = fileManager;
        }

        public List<int> Sort(string sourceFilePath)
        {
            try
            {
                var numbers= _fileManager.ReadCsvFile(sourceFilePath);
                if(numbers.Count == 0)
                    throw new ArgumentOutOfRangeException(nameof(sourceFilePath),"input file is empty.");
      
                return InnerSort(GetNumberList(numbers));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private List<int> GetNumberList(IEnumerable<string> numbers)
        {
            var numberList = new List<int>();

            foreach (var numberString in numbers)
            {
                int numberValue;
                bool success = int.TryParse(numberString, out numberValue);
                if (!success) continue;

                numberList.Add(numberValue);
            }

            return numberList;
        }

        private List<int> InnerSort(List<int> numberList)
        {
            numberList.Sort();

            return numberList;
        }
    }
}
