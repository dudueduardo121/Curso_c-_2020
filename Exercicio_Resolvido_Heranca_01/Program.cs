using System;
using System.Collections.Generic;
using Exercicio_Resolvido_Heranca_01.Entidades;
using System.Globalization;

namespace Exercicio_Resolvido_Heranca_01 {
    class Program {
        static void Main(string[] args) {

            List<Funcionario> list = new List<Funcionario>();

            Console.Write("Entre com a quantidade de Funcionarios: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"Entre com #{i} Funcionario:");
                Console.Write("É Terceirizado (s/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor Hora: ");
                double vlHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 's') {
                    Console.Write("Despesa Adicional: ");
                    double desAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new FuncionarioTercerizado(nome, horas, vlHora, desAdicional));
                }
                else {
                    list.Add(new Funcionario(nome, horas, vlHora));
                }

            }

            Console.WriteLine();
            Console.WriteLine("Pagamentos:");

            // Emprime a lista de funcionarios cadastrados
            foreach(Funcionario func in list) {
                Console.WriteLine(func.Nome + " - $"+ func.Pagamento().ToString("f2"), CultureInfo.InvariantCulture);
            }

        }
    }
}
