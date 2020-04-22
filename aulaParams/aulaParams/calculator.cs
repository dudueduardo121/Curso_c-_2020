using System;
using System.Collections.Generic;
using System.Text;

namespace aulaParams {
    class calculator {
        public static int Sum(params int[] numeros) {
            int sum = 0;
            for (int i = 0; i < numeros.Length; i++) {
                sum += numeros[i];
            }
            return sum;
        }
    }
}
