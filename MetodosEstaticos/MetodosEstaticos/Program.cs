using System;
using System.Globalization;

namespace MetodosEstaticos {
    class Program {

        static void Main(string[] args) {

            //Console.WriteLine("Qual é a cotação do dólar?");
            //double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Qual a cotação atual do dolar: " + ConversorDeMoeda.Dolar.ToString("f2", CultureInfo.InvariantCulture)+ " U$");

            Console.WriteLine("Quantos dólares você vai compra?");
            double valorCompra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double real = ConversorDeMoeda.ConverterDolar(valorCompra);

            Console.WriteLine("Valor a ser pago em real: " + real.ToString("f2", CultureInfo.InvariantCulture) + " R$");

            







            //  MEMBROS ESTATICOS

            //Console.Write("Entre com valor do Raio: ");
            //double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double circ = Calculadora.Circunferencia(raio);
            //double volume = Calculadora.Volume(raio);

            //Console.WriteLine("Circunferencia: " + circ.ToString("f2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Volume: " + volume.ToString("f2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("f2", CultureInfo.InvariantCulture));


        }

    }
}
