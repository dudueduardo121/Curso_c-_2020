using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Resolvido_Heranca_01.Entidades {
    class FuncionarioTercerizado : Funcionario {
        public double DespesaAdicional { get; set; }

        public FuncionarioTercerizado() {
        }

        public FuncionarioTercerizado(string nome, int horasTrabalhadas, double valorHora, double despesaAdicional) 
            : base(nome, horasTrabalhadas,valorHora) {
            DespesaAdicional = despesaAdicional;
        }

        public override double Pagamento() {
            return base.Pagamento() + 1.1 * DespesaAdicional;
        }
    }
}
