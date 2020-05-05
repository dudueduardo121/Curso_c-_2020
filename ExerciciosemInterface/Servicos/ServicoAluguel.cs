using System;
using ExerciciosemInterface.Entidades;

namespace ExerciciosemInterface.Servicos {
    class ServicoAluguel {
        public double ValorHora { get; private set; }
        public double valorDia { get; private set; }

        public ServicoAluguel(double valorHora, double valorDia) {
            ValorHora = valorHora;
            this.valorDia = valorDia;
        }

        public void processoFatura(AluguelCarro aluguelCarro) {

        }
    }
}
