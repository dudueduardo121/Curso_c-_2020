using MetodosAbstratos.Entidades.Enums;
namespace MetodosAbstratos.Entidades {
    class Retangulo : Figura {

        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura, Cor cor): base(cor) {
            this.Largura = largura;
            this.Altura = altura;
        }
        public override double Area() {
            return Largura * Altura;
        }
    }
}
