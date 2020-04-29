using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entidades {
    class ContaEmpresa : Conta{
        public double limiteEsprestimo { get; set; }

        public ContaEmpresa() {
        }
        public ContaEmpresa(int numero, string titular, double saldo, double limiteEsprestimo) : base(numero,titular,saldo) {
            this.limiteEsprestimo = limiteEsprestimo;
        }

        public void Emprestimo(double quantia) {
            if(quantia <= limiteEsprestimo) {
                Saldo += quantia;
            }
            
        }
    }
}
