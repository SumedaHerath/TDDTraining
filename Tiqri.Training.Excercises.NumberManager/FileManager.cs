﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tiqri.Training.Excercises.NumberManager
{
    public class FileManager : IFileManager
    {
        public List<string> ReadCsvFile(string filePath)
        {
            if(string.IsNullOrEmpty(filePath))
                throw new ArgumentOutOfRangeException(nameof(filePath),"Invalid input file.");

            return File.ReadAllText(filePath).Split(',').ToList();
        }
    }
}