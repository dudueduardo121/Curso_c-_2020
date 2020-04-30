using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_Fixacacao.Entidades.Exceptions;

namespace Exercicio_Fixacacao.Entidades {
    class Reserva {

        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reserva() {
        }
        public Reserva(int roomNumber, DateTime checkIn, DateTime checkOut) {
            if (checkOut <= checkIn) {
                throw new DominioException("Erro 02");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duracao() {
            // Função pega a diferença entre a entrada e saida com total de dias
            TimeSpan duracao = CheckOut.Subtract(CheckIn);
            return (int)duracao.TotalDays;
        }

        public void UpdateDatas(DateTime checkIn, DateTime checkOut) {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now) {
                throw new DominioException("Erro 01");
            }
            if (checkOut <= checkIn) {
                throw new DominioException("Erro 02");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString() {
            return "Room"
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", Check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duracao()
                + " nigths";

        }
    }
}
