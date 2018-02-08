using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class ExerciseFilesCreator
    {
        static public void test()
        {
            StreamWriter sw;
            string language = string.Empty;
            int count = Enum.GetNames(typeof(Languages)).Length;
            for (int i = 0; i < count; i++)
            {
                language = Enum.GetValues(typeof(Languages)).GetValue(i).ToString();
                Console.WriteLine(language);
                Directory.CreateDirectory(@"C:\jmTEMP\Languages");
                Directory.CreateDirectory(@"C:\jmTEMP\Languages\" + language);
                sw = new StreamWriter("C:\\jmTEMP\\Languages\\" + language + "\\log.txt");
                sw.WriteLine("File no " + i + " created on " + DateTime.Now);
                sw.Close();
            }
        }
    }


    enum Languages
    {
        Arabic,
        Azerbaijani,
        Bengali,
        Czech,
        Dutch,
        English,
        French,
        German,
        Greek,
        Hindi,
        Hungarian,
        Italian,
        Japanese,
        Javanese,
        Korean,
        Kurdish,
        Malay,
        Mandarin,
        Persian,
        Polish,
        Portuguese,
        Romanian,
        Russian,
        Spanish,
        Swedish,
        Thai,
        Turkish,
        Ukrainian,
        Urdu,
        Vietnamese,
        Zulu
    }
}
