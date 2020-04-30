using MetodosAbstratos.Entidades.Enums;
using System;

namespace MetodosAbstratos.Entidades {
    class Circulo : Figura{
        public double Raio { get; set; }

        public Circulo(double raio, Cor cor): base(cor) {
            Raio = raio;
        }

        public override double Area() {
            return Math.PI * Raio * Raio;
        }
    }
}
