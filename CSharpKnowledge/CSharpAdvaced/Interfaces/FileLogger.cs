using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    class FileLogger : ILogger
    {
        private string _filePath;

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        public void LogError(string errorMessage)
        {
            if (string.IsNullOrEmpty(errorMessage))
                return;
            WriteToFile(errorMessage);
        }

        public void LogInfo(string infoMessage)
        {
            if (string.IsNullOrEmpty(infoMessage))
                return;
            WriteToFile(infoMessage);
        }

        public void WriteToFile(string line)
        {
            if (line == null)
                return;
            using(var ts = new System.IO.StreamWriter(_filePath))
            {
                ts.WriteLine(line);
            }
        }
    }
}
