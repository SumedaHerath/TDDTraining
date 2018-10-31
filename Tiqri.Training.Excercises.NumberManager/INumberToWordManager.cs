using System.Collections.Generic;

namespace Tiqri.Training.Excercises.NumberManager
{
    public interface INumberToWordManager
    {
        List<string> Convert(List<int> numbers);
    }
}