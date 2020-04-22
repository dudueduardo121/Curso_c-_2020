using System;

namespace progama {
    class Program {
        static void Main(string[] args) {
            //var x = int.Parse(Console.ReadLine());
            //string dia;

            //switch (x) {
            //    case 1:
            //        dia = "Domingo";
            //        break;
            //    case 2:
            //        dia = "Segunda";
            //        break;
            //    case 3:
            //        dia = "Terça";
            //        break;
            //    case 4:
            //        dia = "Quarta";
            //        break;
            //    case 5:
            //        dia = "Quinta";
            //        break;
            //    case 6:
            //        dia = "Sexta";
            //        break;
            //    case 7:
            //        dia = "Sabado";
            //        break;
            //    default:
            //        dia = "Dia invalido";
            //        break;
            //}
            //Console.WriteLine("Dia: " + dia);

            var n1 = 5;
            var n2 = 4;

            var tot = n1 > n2 ? "n1 e maior que n2" : "n2 e maior que n1";

            Console.WriteLine(tot);
        }
    }
}
