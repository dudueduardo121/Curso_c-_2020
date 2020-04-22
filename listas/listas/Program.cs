using System;
using System.Collections.Generic;

namespace listas {
    class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();
            // Add
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            // Insert
            list.Insert(2, "marco");

            
            //para cada string de um objeto na lista imprima o obj 
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            //count
            Console.WriteLine("List Count", list.Count);

            // find
            string s1 = list.Find(x  => x[0] == 'A');
            Console.WriteLine("primeiro elemento que inicia com 'A': " + s1);

            //findLast
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Primeiro elemento que termina com 'A': " +s1);

            //findindex
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("primeira posição 'A': " +pos1);

            //findlastindex
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("ultima posição 'A': " + pos2);

            //findAll
            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach(string obj in list2) {
                Console.WriteLine(obj);
            }

            //remove
            list.Remove("Alex");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            //removeAll

            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            //removeAt
            list.RemoveAt(2);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            //removeRange
            list.RemoveRange(2, 2);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
