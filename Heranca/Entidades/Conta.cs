using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entidades {
   abstract class Conta {
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

        public virtual void Saque(double quantia) {
            Saldo -= quantia + 5.0;
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }
    }
}
