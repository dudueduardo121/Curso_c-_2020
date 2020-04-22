using System;
using System.Globalization;

namespace MetodosEstaticos {
    class Calculadora {
        public static double Pi = 3.14;

        // função Circunferencia
        public static double Circunferencia(double raio) {
            return 2.0 * Pi * raio;
        }

        // Função Volume
        public static double Volume(double raio) {
            return 4.0 / 3.0 * Pi * raio * raio * raio;
        }

    }
}
