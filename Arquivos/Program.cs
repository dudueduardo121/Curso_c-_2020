using System;
using System.IO;

namespace Arquivos {
    class Program {
        static void Main(string[] args) {

            string caminho = @"c:\temp\file.txt";
            string destino = @"c:\temp\file2.txt";

            try {
                FileInfo fileInfo = new FileInfo(caminho);
                fileInfo.CopyTo(destino);

                string[] linhas = File.ReadAllLines(caminho);
                foreach(string linha in linhas) {
                    Console.WriteLine(linha);
                }

            }catch(IOException e) {
                Console.WriteLine("um erro ocorreu");
                Console.WriteLine(e.Message);
            }
        }
    }
}
