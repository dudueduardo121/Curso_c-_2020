using System;
using Exercicio_Fixacacao.Entidades;
using Exercicio_Fixacacao.Entidades.Exceptions;

namespace Exercicio_Fixacacao {
    class Program {
        static void Main(string[] args) {

            try {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reserva reserva = new Reserva(number, checkIn, checkOut);
                Console.WriteLine("Reserva: " + reserva);

                //------------------RESERVA ATUALIZADA----------------------//

                Console.WriteLine();
                Console.WriteLine("Entre com os dados para atualizar a reserva:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reserva.UpdateDatas(checkIn, checkOut);
                Console.WriteLine("Reserva Atualizada: " + reserva);
            }
            catch (DominioException erro) {
                Console.WriteLine("Erro ->" + erro.Message);
            }
            

        

        }
    }
}
