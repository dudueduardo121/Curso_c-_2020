using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Services;
using SalesWebMvc.Services.Exceptions;

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

        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido!"});
            }

            var obj = _vendedorServico.FindById(Id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado!" });
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int Id)
        {
            _vendedorServico.Remover(Id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int? Id)
        {
            if (Id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido!" });
            }

            var obj = _vendedorServico.FindById(Id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado!" });
            }

            return View(obj);
        }

        public IActionResult Edit(int? Id)
        {
            if(Id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido!" });
            }

            var obj = _vendedorServico.FindById(Id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado!" });
            }

            List<Departamento> departamentos = _departamentoServico.FindAll();
            formVendedorViewModel viewModel = new formVendedorViewModel { Vendedor = obj, Departamentos = departamentos };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int Id, Vendedor vendedor)
        {
            if(Id != vendedor.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não correspondem!" });
            }

            try
            {
                _vendedorServico.Update(vendedor);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
           
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}