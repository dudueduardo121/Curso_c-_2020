using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entidades {
    class Conta {
        public int numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        public Conta() {
        }
        public Conta(int numero, string titular, double saldo) {
            this.numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Saque(double quantia) {
            Saldo -= quantia;
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }
    }
}
