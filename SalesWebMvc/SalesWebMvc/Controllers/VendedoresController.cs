using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorServico _vendedorServico;
        private readonly DepartamentoServico _departamentoServico;

        public VendedoresController(VendedorServico vendedorServico, DepartamentoServico departamentoServico)
        {
            _vendedorServico = vendedorServico;
            _departamentoServico = departamentoServico;
        }
        public IActionResult Index()
        {
            // passa a lista como argumento no methodo view
            var list = _vendedorServico.findAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var departamentos = _departamentoServico.FindAll();
            var viewModel = new formVendedorViewModel { Departamentos = departamentos };
            return View(viewModel);
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