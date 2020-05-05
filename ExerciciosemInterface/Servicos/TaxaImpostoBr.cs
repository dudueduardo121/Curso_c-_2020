using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosemInterface.Servicos {
    class TaxaImpostoBr {
        public double Imposto(double valor) {
            if(valor <= 100.0) {
                return valor * 0.2;
            }
            else {
                return valor * 0.15;
            }
        }
    }
}
