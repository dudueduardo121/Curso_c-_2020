using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Services.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class VendedorServico
    {
        private readonly SalesWebMvcContext _context;

        public VendedorServico(SalesWebMvcContext context)
        {
            _context = context;
        }

        // operação syncrona

        /*public List<Vendedor> findAll()
        {
            // acessar os dados vendedores a atribui a uma list
            return _context.Vendedor.ToList();
        }*/

        // operação Asyncrona

        public async Task<List<Vendedor>> FindAllAsync()
        {
            return await _context.Vendedor.ToListAsync();
        }

        public async Task InserirAsync(Vendedor obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Vendedor> FindByIdAsync(int Id)
        {
            return await _context.Vendedor.Include(obj => obj.Departamento).FirstOrDefaultAsync(obj => obj.Id == Id);
        }

        public async Task RemoverAsync(int Id)
        {
            try
            {
                var obj = await _context.Vendedor.FindAsync(Id);
                _context.Vendedor.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegridadeExcessao("Vendedor não pode ser deletador pois o mesmo ainda possui vendas em ativo.");
            }
        }

        public async Task UpdateAsync(Vendedor obj)
        {
            bool hasAny = await _context.Vendedor.AnyAsync(x => x.Id == obj.Id);

            if (!hasAny)
            {
                throw new NotFoundException("Id não encoontrado");
            }

            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
           
        }
    }
}
