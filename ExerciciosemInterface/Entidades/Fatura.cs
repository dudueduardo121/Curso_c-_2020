using System;
using System.Globalization;

namespace ExerciciosemInterface.Entidades {
    class Fatura {

        public double PagamentoBasico { get; set; }
        public double Imposto { get; set; }

        public Fatura(double pagamentoBasico, double imposto) {
            PagamentoBasico = pagamentoBasico;
            this.Imposto = imposto;
        }
        // Propriedade calculada
        public double PagamentoTotal {
            get { return PagamentoBasico + Imposto; }
        }

        public override string ToString() {
            return "Pagamento Basico: "
                + PagamentoBasico.ToString("f2", CultureInfo.InvariantCulture)
                + "\nImposto: "
                + Imposto.ToString("f2", CultureInfo.InvariantCulture)
                + "\nTotal Pagamento: "
                + PagamentoTotal.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
