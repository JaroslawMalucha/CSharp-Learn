using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class WorkingWithFiles
    {
        public static void testFiles()
        {
            CreateTestFile();
            FileAndFileInfo();
            DirectoryAndDirectoryinfo();
            Exercise1();
            Exercise2();

            writeFile_StreamWriter();
            readFile_StreamReader();
        }

        public static void CreateTestFile()
        {
            var root = Directory.GetCurrentDirectory();
            var fPath = Path.Combine(root, @"testFile.txt");
            var fs1 = File.Create(fPath); fs1.Close();
        }


        public static void FileAndFileInfo()
        {
            // File class is a static class
            //  each access triggers a security check in the OS to see if actor has permissions
            //  => multiple calls can become slow due to that
            // FileInfo is an object class (instantiable)
            //  only creation triggers a security check in the OS to see if actor has permissions
            //  => multiple calls will be faster
            //  does not have a ReadAll... methods
            //  => instead has OpenRead that opens a FileSteam
            var root = Directory.GetCurrentDirectory();
            var fPath = Path.Combine(root, @"testFile.txt");
            var fs1 = File.Create(fPath); fs1.Close();
            var fPath2 = Path.Combine(root, @"testFile - Copy.txt");
            File.Copy(fPath, fPath2, true); //uses full PathName paths
            if (File.Exists(fPath))
            {

            }
            var content = File.ReadAllText(fPath);

            var fInfo = new FileInfo(fPath);
            fInfo.CopyTo(fPath2, true).Delete();
            //fInfo.Delete();
            if (fInfo.Exists)
            {
                //
            }
            FileStream fs = fInfo.OpenRead();
            fs.Close();
        }

        public static void DirectoryAndDirectoryinfo()
        {
            var p = @"";
            //Directory.CreateDirectory(p);
            p = System.AppDomain.CurrentDomain.BaseDirectory;  //@"D:\Jarek\Projects\VSProjects\C#\_JMproj\basics";
            var files = Directory.GetFiles(p, "*.*", SearchOption.AllDirectories); //files only
            Console.WriteLine(files.Length);
            files = Directory.GetFiles(p, "*.sln", SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file);
            Console.WriteLine(files.Length);

            var dirs = Directory.GetDirectories(p, "*.*", SearchOption.AllDirectories); //folders only
            foreach (var file in dirs)
                Console.WriteLine(file);
            Console.WriteLine(dirs.Length);

            Directory.Exists(p);

            var dirInfo = new DirectoryInfo(p);
            dirInfo.GetFiles();
            dirInfo.GetDirectories();
        }



        public static void PathClass()
        {
            var p = @"testFile.txt";

            Console.WriteLine("Extension: " + Path.GetExtension(p));
            Console.WriteLine("File Name: " + Path.GetFileName(p));
            Console.WriteLine("File Name without extension: " + Path.GetFileNameWithoutExtension(p));
            Console.WriteLine("Dir Name: " + Path.GetDirectoryName(p));
            Console.WriteLine("File Name: " + Path.GetFileName(p));
        }


        //Write a program that reads a text file and displays the number of words.
        public static void Exercise1()
        {
            var p = @"testFile.txt";
            var text = File.ReadAllText(p, Encoding.Default);
            var words = GetWordsList(text);
            WorkingWithText.PrintCollection(words);
            Console.WriteLine(words.Count);

        }

        //Write a program that reads a text file and displays the longest word in the file.
        public static void Exercise2()
        {
            var p = @"testFile.txt";
            var text = File.ReadAllText(p, Encoding.Default);
            Console.WriteLine(GetLongestWord(GetWordsList(text)));
        }

        public static List<string> GetWordsList(string text)
        {
            return text.Split(' ').ToList();
        }

        public static string GetLongestWord(List<string> words)
        {
            if (words.Count == 0)
                throw new Exception();
            int maxLen = words[0].Length;
            int maxIndex = 0 ;
            for ( int i = 1 ; i < words.Count ; i++)
                if (words[i].Length > maxLen)
                {
                    maxLen = words[i].Length;
                    maxIndex = i;
                }
            return words[maxIndex];
        }



        public static void writeFile_StreamWriter()
        {
            string folder = @"C:\jmTEMP\files";
            Directory.CreateDirectory(folder);
            string fileName = @"Names.txt";
            string file = Path.Combine(folder, fileName);

            StreamWriter sw = new StreamWriter(file, true);
            sw.WriteLine("asf");
            sw.WriteLine("xxx");
            sw.WriteLine("asfasf");
            sw.Close();

        }


        public static void readFile_StreamReader()
        {
            string folder = @"C:\jmTEMP\files";
            Directory.CreateDirectory(folder);
            string fileName = @"Names.txt";
            string file = Path.Combine(folder, fileName);

            System.IO.StreamReader sr = new StreamReader(file);
            Console.WriteLine(sr.ReadToEnd() ); 
            sr.Close();

        }
    }
}
