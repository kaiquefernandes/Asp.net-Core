﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjFinanceiro.Controllers
{
    public class PlanoContaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}