using Enumeracao.Entities;
using Enumeracao.Entities.Enums;
using System;

namespace Enumeracao {
    class Program {
        static void Main(string[] args) {
            Pedidos Pedido_1 = new Pedidos {
                id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PagamentoPendente
            };

            Console.WriteLine(Pedido_1);

            //CONVERSÃO DE INTEIRO PARA STRING
            string txt = OrderStatus.PagamentoPendente.ToString();

            Console.WriteLine(txt);

            // CORREÇÃO STRING PARA INTEIRO
            OrderStatus os = Enum.Parse<OrderStatus>("Entregue");
            Console.WriteLine(os);
        }
    }
}
