using System;
using System.Globalization;

namespace ProjetoUm {
    class ContaBancaria {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }

        public ContaBancaria(int numero, string titular, double depositoinicial) : this(numero, titular) {
            Deposito(depositoinicial);
        }

        public void Deposito(double Valordeposito) {
             Saldo += Valordeposito;
        }

        public void Saque(double ValorSaque) {
            double taxa = 5.0;
            Saldo -= ValorSaque + taxa ;
        }


        public override string ToString() {
            return "Conta " + Numero
                   +
                   ", Titular: " + Titular
                   +
                   ", Saldo: $ " + Saldo.ToString("f2", CultureInfo.InvariantCulture);
        }

    }
}
