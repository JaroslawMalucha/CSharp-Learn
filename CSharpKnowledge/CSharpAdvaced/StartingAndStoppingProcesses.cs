using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace CSharpAdvanced
{
    class StartingAndStoppingProcesses
    {
        public static void test()
        {
            // by proccess name as visible in the task manager
            Process p = Process.Start("Notepad.exe");p.Kill();
            Process.Start(@"C:\");
            Process.Start("chrome.exe"); 
            Process.Start("https://www.facebook.com");
            

            Process[] notepads = Process.GetProcessesByName("notepad");
            foreach (var process in notepads)
            {
                process.Kill();
            }

            NotepadExercise();
        }

        private static void NotepadExercise()
        {
            System.IO.File.WriteAllText(@"C:\jmTEMP\notepadExercise.txt", "follow the white rabbit :)");
            Process p = System.Diagnostics.Process.Start(@"C:\jmTEMP\notepadExercise.txt");
            Thread.Sleep(1000);
            p.Kill();
        }
    }
}
