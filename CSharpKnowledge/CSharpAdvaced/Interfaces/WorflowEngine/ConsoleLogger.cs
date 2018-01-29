using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Interfaces.WorflowEngine
{
    class ConsoleLogger : ILogger
    {
        public void LogError(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }
        public void LogInfo(string infoMessage)
        {
            Console.WriteLine(infoMessage);
        }
    }
}
