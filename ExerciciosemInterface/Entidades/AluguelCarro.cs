using System;

namespace ExerciciosemInterface.Entidades {
    class AluguelCarro {
        public DateTime inicio { get; set; }
        public DateTime Fim { get; set; }
        public Veiculo veiculo { get; set; }
        public Fatura Fatura { get; set; }

        public AluguelCarro(DateTime inicio, DateTime fim, Veiculo veiculo) {
            this.inicio = inicio;
            Fim = fim;
            this.veiculo = veiculo;
        }
    }
}
