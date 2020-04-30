using MetodosAbstratos.Entidades.Enums;

namespace MetodosAbstratos.Entidades {
   abstract class Figura {
        public Cor Cor { get; set; }

        public Figura(Cor cor) {
            Cor = cor;
        }

        public abstract double Area(); 
    }
}
