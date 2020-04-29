using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entidades {
    class ContaPoupansa : Conta {
        public double TaxadeJuros  { get; set; }

        public ContaPoupansa() {
        }

        public ContaPoupansa(int numero, string titular, double saldo, double taxadeJuros) : base(numero, titular, saldo) {
            TaxadeJuros = taxadeJuros;
        }

        public void AtualizarSaldo() {
            Saldo = Saldo * TaxadeJuros;
        }

        public override void Saque(double quantia) {
            base.Saque(quantia);
            Saldo -= 2.0;
        }
    }
}
