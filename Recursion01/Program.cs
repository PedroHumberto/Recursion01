using System;
using System.IO;

namespace Recursion01
{
    class Program
    {


        static void ReadFile(int fileNumber)
        {
            string fileWithPath = @"D:\C#\Exercicios\Recursion01\Recursion01\file" + fileNumber + ".txt";
            if (File.Exists(fileWithPath))
            {
                using (StreamReader file = File.OpenText(fileWithPath))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                string fileWithPath2 = @"D:\C#\Exercicios\Recursion01\Recursion01\file" + (fileNumber + 1) + ".txt";
                if (File.Exists(fileWithPath2))
                {
                    ReadFile(fileNumber + 1);
                }
            }
        }

        static void Main(string[] args)
        {
            ReadFile(1);
        }
    }

    
}
