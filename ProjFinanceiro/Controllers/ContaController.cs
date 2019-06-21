using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjFinanceiro.Models;
using ProjFinanceiro.util;

namespace ProjFinanceiro.Controllers
{
    public class ContaController : Controller
    {
        public IActionResult Index()
        {
            ContaModel conta = new ContaModel();
            ViewBag.ListaConta = conta.ListaConta();
            return View();
        }


        [HttpPost]
        public IActionResult Conta(ContaModel formulario)
        {
            if (ModelState.IsValid) {
                formulario.HttpContextAccessor = HttpContextAccessor;
                formulario.Insert();
                return RedirectToAction("index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Conta()
        {

            return View();
        }

        IHttpContextAccessor HttpContextAccessor;
        public ContaController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }


        [HttpGet]
        public IActionResult ExcluirConta(int id) {

            ContaModel conta = new ContaModel(HttpContextAccessor);
            conta.ExcluirConta(id);
            return RedirectToAction("Index");
        }
    }

}