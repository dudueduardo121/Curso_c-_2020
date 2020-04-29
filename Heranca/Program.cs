using System;
using Heranca.Entidades;

namespace Heranca {
    class Program {
        static void Main(string[] args) {

            Conta acc1 = new Conta(1001, "Alex", 500.0);
            Conta acc2 = new ContaPoupansa(1002, "Edu", 500.0, 0.01);

            acc1.Saque(10.0);
            acc2.Saque(10.0);

            Console.WriteLine(acc1.Saldo);
            Console.WriteLine(acc2.Saldo);

        }
    }
}
