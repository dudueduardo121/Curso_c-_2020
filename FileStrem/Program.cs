using System;
using System.IO;

namespace FileStrem {
    class Program {
        static void Main(string[] args) {

            string origem = @"c:\temp\file.txt";
            string destino = @"c:\temp\file2.txt";

            try {
                string[] lines = File.ReadAllLines(origem);

                using (StreamWriter sw = File.AppendText(destino)) {
                    foreach (string line in lines) {
                        sw.WriteLine(line.ToUpper());
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
