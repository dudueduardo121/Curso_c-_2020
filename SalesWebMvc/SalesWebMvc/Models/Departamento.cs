using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {
        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public void AddVendedor(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }

        public double TotalVendas(DateTime inicial, DateTime final )
        {
            // pega cada vendedor da lista e soma o totalvedas de todos os vendedores 
            return Vendedores.Sum(vendedor => vendedor.TotalVendas(inicial, final));
        }

    }
}
