using System;
using System.Globalization;

namespace ProjetoUm {
    class Funcionario {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido() {
            return Salario - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            Salario = Salario + (Salario * porcentagem / 100.0);
        }

        public override string ToString() {
            return
                Nome
                + " , $ "
                + SalarioLiquido().ToString("f2", CultureInfo.InvariantCulture);
                
        }
    }
}
