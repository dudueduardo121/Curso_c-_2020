using System;
using System.Globalization;
using System.Collections.Generic;

namespace exercicioListaFuncionarios {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Quantos Funcionarios deseja cadastrar? ");

            int nFuncinarios = int.Parse(Console.ReadLine());

            List<Funcionarios> list = new List<Funcionarios>();

            for(int i= 1; i<= nFuncinarios; i++) {
                Console.WriteLine("Funcionarios #"+ i + ":");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("NOME: ");
                string nome = Console.ReadLine();
                Console.Write("SALARIO: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionarios(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Emtre com o ID do funcionario: ");
            int bucarId = int.Parse(Console.ReadLine());

            Funcionarios func = list.Find(x => x.id == bucarId);
            if (func != null) {
                Console.Write("Entre com Porcentagem: ");
                double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.incrementarSalario(percentual);
            }
            else {
                Console.WriteLine("Não há funcionario cadastrado com esse ID!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada dos funcionarios:");

            foreach(Funcionarios obj in list) {
                Console.WriteLine(obj);
            }

        }
    }
}
