using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Threading;

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

            while (!prompt.IsCompleted) { Console.WriteLine("...waiting to complete speech"); Thread.Sleep(500); }
            robot.Speak("Ohh, My King.");

            robot.SetOutputToWaveFile(@"C:\jmTEMP\nabu.wav");
            robot.SpeakAsync("Hello, Nebuchadnezzar");
            robot.Speak("Ohh, My King.");

            "Bamboo".Speak();

            Console.WriteLine("done");
        }

    }

    static class StringExtensionsSpeech
    {
        public static void Speak(this string textToSpeak)
        {
            SpeechSynthesizer robot = new SpeechSynthesizer();
            robot.Speak(textToSpeak);
        }
    }
}
