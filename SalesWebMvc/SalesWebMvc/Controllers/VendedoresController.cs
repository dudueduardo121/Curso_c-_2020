using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorServico _vendedorServico;

        public VendedoresController(VendedorServico vendedorServico)
        {
            _vendedorServico = vendedorServico;
        }
        public IActionResult Index()
        {
            // passa a lista como argumento no methodo view
            var list = _vendedorServico.findAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] // Indicar que uma ação de POST
        [ValidateAntiForgeryToken]// previnir ataques na sessão CSRF
        public IActionResult Create(Vendedor vendedor)
        {
            _vendedorServico.Inserir(vendedor);
            return RedirectToAction(nameof(Index));
        }
    }
}