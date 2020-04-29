using System;
using Heranca.Entidades;

namespace Heranca {
    class Program {
        static void Main(string[] args) {

            Conta acc = new Conta(1001, "Edu", 0.0);
            ContaEmpresa bcc = new ContaEmpresa(1002, "Maria", 0.0, 500.0);

            //UPCASTING converte uma subclasse para uma superclasse

            Conta acc1 = bcc;
            Conta acc2 = new ContaEmpresa(1003, "bob", 0.0, 200.0);
            Conta acc3 = new ContaPoupansa(1004, "Ana", 0.0, 0.01);

            //DAWNCASTING converte uma superclasse para subclasse so e usado somente se muito necessario

            ContaEmpresa acc4 = (ContaEmpresa)acc2;
            acc4.Emprestimo(100.0);

            //ContaEmpresa acc5 = (ContaEmpresa)acc3;// erro

            if(acc3 is ContaEmpresa) {
                //ContaEmpresa acc5 = (ContaEmpresa)acc3;
                ContaEmpresa acc5 = acc3 as ContaEmpresa;
                acc5.Emprestimo(200.0);
                Console.WriteLine("Emprestimo");
            }

            if(acc3 is ContaPoupansa) {
                //ContaPoupansa acc5 = (ContaPoupansa)acc3;
                ContaPoupansa acc5 = acc3 as ContaPoupansa;
                acc5.AtualizarSaldo();
                Console.WriteLine("Atualizado!");
            }



        }
    }
}
