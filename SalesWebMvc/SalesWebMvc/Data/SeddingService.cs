using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeddingService
    {
        //registrar dependencia
        private SalesWebMvcContext _context;

        public SeddingService(SalesWebMvcContext context)
        {
            _context = context;
        }
        // popula a base de dados
        public void Seed()
        {
            // Verifica se já tem algo registrado na base de dados
            if (_context.Departamento.Any() || _context.Vendedor.Any() || _context.RegistroVendas.Any())
            {
                return; // banco de dados populado
            }
            Departamento d1 = new Departamento(4, "Cellphones");
            Departamento d2 = new Departamento(5, "Notebooks");
            Departamento d3 = new Departamento(6, "Games");
            Departamento d4 = new Departamento(7, "Books");

            Vendedor s1 = new Vendedor(1, "Bob Brow", "Bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Vendedor s2 = new Vendedor(2, "Juca Quifuri", "Juca@gmail.com", new DateTime(1988, 5, 10), 2000.0, d4);
            Vendedor s3 = new Vendedor(3, "Alex Rub", "Alex@gmail.com", new DateTime(1978, 6, 1), 2000.0, d3);
            Vendedor s4 = new Vendedor(4, "Jonh Cabira", "Jonh@gmail.com", new DateTime(1968, 1, 2), 3000.0, d2);
            Vendedor s5 = new Vendedor(5, "Donald Trunp", "Donald@gmail.com", new DateTime(1999, 7, 3), 3000.0, d1);
            Vendedor s6 = new Vendedor(6, "Bill Clinton", "Bill@gmail.com", new DateTime(1957, 3, 11), 1000.0, d3);
            Vendedor s7 = new Vendedor(7, "Barac Obama", "Barac@gmail.com", new DateTime(2000, 1, 13), 4000.0, d2);

            RegistroVendas r1 = new RegistroVendas(1, new DateTime(2018, 09, 05), 11000.0, VendasAtualizada.Faturado, s1);
            RegistroVendas r2 = new RegistroVendas(2, new DateTime(2018, 10, 10), 12000.0, VendasAtualizada.Pendente, s2);
            RegistroVendas r3 = new RegistroVendas(3, new DateTime(2018, 11, 22), 13000.0, VendasAtualizada.Cancelado, s7);
            RegistroVendas r4 = new RegistroVendas(4, new DateTime(2019, 01, 01), 14000.0, VendasAtualizada.Faturado, s3);
            RegistroVendas r5 = new RegistroVendas(5, new DateTime(2019, 02, 10), 15000.0, VendasAtualizada.Cancelado, s4);
            RegistroVendas r6 = new RegistroVendas(6, new DateTime(2020, 03, 11), 16000.0, VendasAtualizada.Faturado, s5);
            RegistroVendas r7 = new RegistroVendas(7, new DateTime(2020, 04, 23), 17000.0, VendasAtualizada.Pendente, s6);

            // adicionar no banco
            _context.Departamento.AddRange(d1, d2, d3, d4);
            _context.Vendedor.AddRange(s1, s2, s3, s4, s5, s6, s7);
            _context.RegistroVendas.AddRange(r1, r2, r3, r4, r5, r6, r7);

            _context.SaveChanges();

        }
    }
}
