using SalesWebMvc.Models.Enums;
using System;

namespace SalesWebMvc.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Montante { get; set; }
        public VendasAtualizada status { get; set; }
        public Vendedor vendedor { get; set; }

        public RegistroVendas()
        {
        }

        public RegistroVendas(int id, DateTime data, double montante, VendasAtualizada status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Montante = montante;
            this.status = status;
            this.vendedor = vendedor;
        }
    }
}
