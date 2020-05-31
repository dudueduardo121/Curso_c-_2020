using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartamentoServico
    {
        private readonly SalesWebMvcContext _context;

        public DepartamentoServico(SalesWebMvcContext context)
        {
            _context = context;
        }

        // Operação syncrona

        /*public List<Departamento> FindAll()
        //{
        //    return _context.Departamento.OrderBy(x => x.Nome).ToList();
        }*/

        // Operação Asyncrona
        public async Task<List<Departamento>> FindAllAsync()
        {
            return await _context.Departamento.OrderBy(x => x.Nome).ToListAsync();
        }


    }
}
