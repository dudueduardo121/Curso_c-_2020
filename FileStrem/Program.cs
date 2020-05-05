using System;
using System.IO;
using System.Collections.Generic;

namespace FileStrem {
    class Program {
        static void Main(string[] args) {

            string pasta = @"c:\temp";

            try {
                // LISTA PASTAS
               var folder =  Directory.EnumerateDirectories(pasta, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("Folders");
                foreach(string s in folder) {
                    Console.WriteLine(s);
                }
                // LISTA ARQUIVOS DAS PASTAS
                var files = Directory.EnumerateFiles(pasta, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("FILEs");
                foreach (string s in files) {
                    Console.WriteLine(s);
                }
                //CRIAR NOVA PASTA
                Directory.CreateDirectory(pasta + @"\novapasta");

            }
            catch (IOException e) {
                Console.WriteLine("Erro");
                Console.WriteLine(e.Message);
            }

        }
    }
}
