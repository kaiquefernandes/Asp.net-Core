﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjFinanceiro.Controllers
{
    public class TransacaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Extrato()
        {
            return View();
        }

        public IActionResult DashBoard()
        {
            return View();
        }
    }
}