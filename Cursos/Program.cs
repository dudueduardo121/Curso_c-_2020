using System;

namespace Cursos {
    class Program {
        static void Main(string[] args) {

            DateTime dt = new DateTime(2020, 04, 30, 08, 10, 45);
            Console.WriteLine(dt.ElapedTime());

            string s1 = "bom dia Pessoal";
            Console.WriteLine(s1.Cut(3));
        }
    }
}
