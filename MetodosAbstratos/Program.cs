using System;
using MetodosAbstratos.Entidades;
using MetodosAbstratos.Entidades.Enums;
using System.Globalization;
using System.Collections.Generic;

namespace MetodosAbstratos {
    class Program {
        static void Main(string[] args) {

            List<Figura> list = new List<Figura>();

            Console.WriteLine("Entre com o numero de figuras: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($" Figura numero #{i}: ");
                Console.Write("Retangulo ou Circulo (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Cor (Preto/Azul/Vermelho): ");
                Cor cor = Enum.Parse<Cor>(Console.ReadLine());

                if (ch == 'r') {
                    Console.Write("Entre com a Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Entre com a Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Retangulo(largura, altura, cor));
                }
                else {
                    Console.Write("Entre com o Raio do Circulo: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circulo(raio, cor));
                }


            }

            Console.WriteLine();
            Console.WriteLine("Areas das Figuras: ");

            foreach (Figura figura in list) {
                Console.WriteLine(figura.Area().ToString("f2"), CultureInfo.InvariantCulture);
            }
        }
    }
}
