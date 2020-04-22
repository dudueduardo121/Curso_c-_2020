using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace exercicioListaFuncionarios {
    class Funcionarios {
        public int id { get; set; }
        public string nome { get; set; }
        public double salario { get; set; }

        public Funcionarios(int id, string nome, double salario) {
            this.id = id;
            this.nome = nome;
            this.salario = salario;
        }

        public void incrementarSalario(double percentual) {
            salario += salario * percentual / 100.0;
        }

        public override string ToString() {
            return
                "ID "
                +
                id
                + ": "
                + nome
                + ", "
                + salario.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
