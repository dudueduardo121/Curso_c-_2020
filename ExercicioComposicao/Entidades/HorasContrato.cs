using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioComposicao.Entidades {
    class HorasContrato {
        public DateTime Data { get; set; }
        public double ValorHora { get; set; }
        public int DuracaoHoras { get; set; }

        public HorasContrato() {
        }

        public HorasContrato(DateTime data, double valorHora, int duracaoHoras) {
            Data = data;
            ValorHora = valorHora;
            DuracaoHoras = duracaoHoras;
        }

        public double TotalValor() {
             return ValorHora * DuracaoHoras;
        }
    }
}
