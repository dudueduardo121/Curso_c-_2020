using System;
using System.Globalization;
using ExerciciosemInterface.Entidades;

namespace ExerciciosemInterface {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com os dados do aluguel");
            Console.Write("Modelo carro: ");
            string modelo = Console.ReadLine();
            Console.Write("inicio (Dia/Mês/Ano Hr:min)");
            DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Fim (Dia/Mês/Ano Hr:min)");
            DateTime fim = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            AluguelCarro aluguel = new AluguelCarro(inicio, fim, new Veiculo(modelo));

            Console.WriteLine(aluguel);
        }
    }
}
