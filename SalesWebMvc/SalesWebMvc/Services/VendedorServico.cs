using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class VendedorServico
    {
        private readonly SalesWebMvcContext _context;

        public VendedorServico(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Vendedor> findAll()
        {
            // acessar os dados vendedores a atribui a uma list
            return _context.Vendedor.ToList();
        }

        public void Inserir(Vendedor obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
