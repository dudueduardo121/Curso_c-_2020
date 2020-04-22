using System;

namespace aulaParams {
    class Program {
        static void Main(string[] args) {
            string[] vect = new string[] { "maria", "alex", "fabio" };

            foreach(string obj in vect) {
                Console.WriteLine(obj);
            }
        }
    }
}
