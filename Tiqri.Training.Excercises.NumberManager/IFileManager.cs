using System.Collections.Generic;

namespace Tiqri.Training.Excercises.NumberManager
{
    public interface IFileManager
    {
        List<string> ReadCsvFile(string filePath);
    }
}