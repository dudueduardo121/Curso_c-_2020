using System;
using Exercicio_02_24_04_2020.Entidades;

namespace Exercicio_02_24_04_2020 {
    class Program {
        static void Main(string[] args) {

            Comment c1 = new Comment("Tenha uma boa viajem");
            Comment c2 = new Comment("uau, isso é incrível");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:48:50"),
                "Viajar para a nova zelândia",
                "vou visitar esse país maravilhoso!",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Boa Noite");
            Comment c4 = new Comment("Que a força esteja com você");

            Post p2 = new Post(
                DateTime.Parse("03/07/2018 13:48:50"),
                "Boa noite pessoal",
                "Te vejo amanhã",
                5);

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine("COMENTARIOS");
            Console.WriteLine();
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
