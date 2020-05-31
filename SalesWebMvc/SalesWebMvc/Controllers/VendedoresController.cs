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


        // INDEX VIEW

        public async Task<IActionResult> Index()
        {
            // passa a lista como argumento no methodo view
            var list = await _vendedorServico.FindAllAsync();
            return View(list);
        }


        // CREATE

        public async Task<IActionResult> Create()
        {
            var departamentos = await _departamentoServico.FindAllAsync();
            var viewModel = new formVendedorViewModel { Departamentos = departamentos };
            return View(viewModel);
        }



        // CREATE POST

        [HttpPost] // Indicar que uma ação de POST
        [ValidateAntiForgeryToken]// previnir ataques na sessão CSRF
        public async Task<IActionResult> Create(Vendedor vendedor)
        {
            // validação dos campos se foram preenchidos
            if (!ModelState.IsValid)
            {
                var departamentos = await _departamentoServico.FindAllAsync();
                var viewModel = new formVendedorViewModel { Vendedor = vendedor, Departamentos = departamentos };
                return View(viewModel);
            }

            await _vendedorServico.InserirAsync(vendedor);
            return RedirectToAction(nameof(Index));
        }


        // DELETAR

        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido!"});
            }

            var obj = await _vendedorServico.FindByIdAsync(Id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado!" });
            }

            return View(obj);
        }



        // DELETAR POST


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                await _vendedorServico.RemoverAsync(Id);
                return RedirectToAction(nameof(Index));
            }
            catch(IntegridadeExcessao e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message});
            }

        }



        // DETALHES

        public async Task<IActionResult> Detalhes(int? Id)
        {
            if (Id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido!" });
            }

            var obj = await _vendedorServico.FindByIdAsync(Id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado!" });
            }

            return View(obj);
        }



        // EDITAR

        public async Task<IActionResult> Edit(int? Id)
        {
            if(Id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido!" });
            }

            var obj = await _vendedorServico.FindByIdAsync(Id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado!" });
            }

            List<Departamento> departamentos = await _departamentoServico.FindAllAsync();
            formVendedorViewModel viewModel = new formVendedorViewModel { Vendedor = obj, Departamentos = departamentos };
            return View(viewModel);
        }




        //EDITAR POST

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, Vendedor vendedor)
        {
            // validação dos campos se foram preenchidos
            if (!ModelState.IsValid)
            {
                var departamentos = await _departamentoServico.FindAllAsync();
                var viewModel = new formVendedorViewModel { Vendedor = vendedor, Departamentos = departamentos };
                return View(viewModel);
            }

            if (Id != vendedor.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não correspondem!" });
            }

            try
            {
                await _vendedorServico.UpdateAsync(vendedor);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
           
        }


        // ERROR

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