using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Resolvido_Heranca_01.Entidades {
    class Funcionario {
        public string Nome { get; set; }
        public int HorasTrabalhadas { get; set; }
        public double ValorHora { get; set; }

        public Funcionario() {
        }

        public Funcionario(string nome, int horasTrabalhadas, double valorHora) {
            Nome = nome;
            HorasTrabalhadas = horasTrabalhadas;
            ValorHora = valorHora;
        }

        public virtual double Pagamento() {
            return HorasTrabalhadas * ValorHora;
        }
    }
}
