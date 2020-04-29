using System;
using Heranca.Entidades;

namespace Heranca {
    class Program {
        static void Main(string[] args) {

            ContaEmpresa conta = new ContaEmpresa(8010, "Edu", 100.00, 500.0);

            Console.WriteLine(conta.Saldo);


        }
    }
}
