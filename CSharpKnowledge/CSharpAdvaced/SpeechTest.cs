using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;


namespace CSharpAdvanced
{
    class SpeechTest
    {
        public static void test()
        {
            SpeechSynthesizer robot = new SpeechSynthesizer();

            robot.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            robot.Volume = 50;
            robot.Rate = 0;

            var prompt = robot.SpeakAsync("Hello, Nebuchadnezzar");
            Console.WriteLine("Hello, Nebuchadnezzar");
            Console.WriteLine("writing file...");

            while (!prompt.IsCompleted) { Console.WriteLine("...waiting to complete speech"); }
            robot.Speak("Ohh, My King.");

            robot.SetOutputToWaveFile(@"C:\jmTEMP\nabu.wav");
            robot.SpeakAsync("Hello, Nebuchadnezzar");
            robot.Speak("Ohh, My King.");

            Console.WriteLine("done");
        }
    }
}
