using System;
using System.Globalization;

namespace MetodosEstaticos {
    class ConversorDeMoeda {

        public static double Dolar = 4.88;

        public static double ConverterDolar(double real) {
            Dolar = (real * Dolar);
            return Dolar + Dolar * 0.06;
        }

    }
}
