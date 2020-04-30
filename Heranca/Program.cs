using System;
using Heranca.Entidades;
using System.Collections.Generic;
using System.Globalization;

namespace Heranca {
    class Program {
        static void Main(string[] args) {

            List<Conta> list = new List<Conta>();

            list.Add(new ContaPoupansa(1001, "Alex", 500.0, 0.01));
            list.Add(new ContaEmpresa(1002, "Bob", 500.0, 400.0));
            list.Add(new ContaPoupansa(1003, "Maria", 500.0, 0.01));
            list.Add(new ContaEmpresa(1004, "Ana", 500.0, 500.0));

            double soma = 0.0;

            foreach(Conta acc in list) {
                soma += acc.Saldo;
            }

            Console.WriteLine("Total Saldo: " + soma.ToString("f2"), CultureInfo.InvariantCulture);

            foreach(Conta acc in list) {
                acc.Saque(10.0);
            }

            foreach(Conta acc in list) {
                Console.WriteLine("Saldo atualizado para a conta: " 
                    + acc.numero + ": " 
                    + acc.Saldo.ToString("f2"), CultureInfo.InvariantCulture);
            }
        }
    }
}
