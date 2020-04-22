using System;
using System.Globalization;

namespace Comportamentos {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Quantos quartos foram alugados?");


            int qtd = int.Parse(Console.ReadLine());

            Aluguel[] vetorAl = new Aluguel[qtd];

            for (int i = 0; i < qtd; i++) {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vetorAl[i] = new Aluguel { Nome = nome, Email = email, Quartos = quarto };


            }



            Console.WriteLine("Nome " + vetorAl[qtd].Nome);
            Console.WriteLine("Email " + vetorAl[qtd].Email);
            Console.WriteLine("Quarto " + vetorAl[qtd].Quartos);












            //int n = int.Parse(Console.ReadLine());

            //Produto[] vetorProdutos = new Produto[n];

            //for (int i = 0; i < n; i++) {
            //    string nome = Console.ReadLine();
            //    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    vetorProdutos[i] = new Produto { Nome = nome, Preco = preco };
            //}

            //double soma = 0.0;

            //for (int i = 0; i < n; i++) {
            //    soma += vetorProdutos[i].Preco;
            //}

            //double media = soma / n;

            //Console.WriteLine("Preço medio igual a: " + media.ToString("f2", CultureInfo.InvariantCulture));






















            /*
              
                                        Vetores

            

            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];

            for (int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            double soma = 0.0;

            for (int i=0; i < n; i++) {
                soma += vect[i];
            }

            double media = soma / n;

            Console.WriteLine("Altura Media: " + media.ToString("f2", CultureInfo.InvariantCulture));

            */



            //========================================================================================\\

            /*
                                      NULLABLE

            double? x = null;
            double? y = 10.0;

            //pegar o valor padrao que no caso e 0
            Console.WriteLine(x.GetValueOrDefault());

            // verificar se o valor e 0 se não for coloca false
            Console.WriteLine(x.HasValue);

            // não funciona pois um objeto null precisa de um valor
            Console.WriteLine(x.Value);


            // Operador de qualecencia nulla
            double? z = null;
            double? w = 10;

            // se o valor de z e y forem nullos substitui pelo valores informados
            double a = z ?? 5;
            double b = w ?? 10;
            */

            //============================================================================================================================\\



            // Mesmo sendo um Struct e necessario inicializar
            //Point p;
            //p.x = 10;
            //p.y = 20;

            //Console.WriteLine(p);

            //p = new Point();

            //Console.WriteLine(p);

        }
    }
}
