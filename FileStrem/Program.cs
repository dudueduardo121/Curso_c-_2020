using System;
using System.IO;

namespace FileStrem {
    class Program {
        static void Main(string[] args) {

            string path = @"c:\temp\file.txt";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("Erro");
                Console.WriteLine(e.Message);
            }

        }
    }
}
