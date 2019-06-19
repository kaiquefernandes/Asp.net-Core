using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjFinanceiro.Models;

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

        IHttpContextAccessor HttpContextAccessor;
        public ContaController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

    }

}