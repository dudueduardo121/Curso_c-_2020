using System;
using System.Globalization;

namespace ProjetoUm {
    class Retangulo {
        public double Largura;
        public double Altura;

        public double Area() {
            return Largura * Altura;
        }

        public double Perimetro() {
            return 2 * (Largura + Altura);
        }

        public double Diagonal() {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }

        public override string ToString() {
            return
                "AREA = "
                +
                Area().ToString("f2", CultureInfo.InvariantCulture)
                +
                "\n"
                +
                "PERÌMETRO = "
                +
                Perimetro().ToString("f2", CultureInfo.InvariantCulture)
                +
                "\n"
                +
                "DIAGONAL = "
                +
                Diagonal().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
