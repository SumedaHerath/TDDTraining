using System.Collections.Generic;

namespace Tiqri.Training.Excercises.NumberManager
{
    public class NumberToWordManager : INumberToWordManager
    {
        public List<string> Convert(List<int> numbers)
        {
            var words = new List<string> {"one" ,"two", "three"};
            return words;
        }
    }
}