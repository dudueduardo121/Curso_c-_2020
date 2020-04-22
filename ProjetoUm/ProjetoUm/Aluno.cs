using System;
using System.Globalization;

namespace ProjetoUm {
    class Aluno {
        public string NomeAluno;
        public double N1;
        public double N2;
        public double N3;

        public double NotaFinal() {
            return (N1 + N2 + N3);

        }

        public bool Aprovado() {
            if (NotaFinal() >= 60.0) {
                return true;
            }
            else {
                return false;
            }
        }

        public double NotaRestante() {
            if (Aprovado()) {
                return 0.0;
            }
            else {
                return 60.0 - NotaFinal();
            }
        }
        
    }
}
