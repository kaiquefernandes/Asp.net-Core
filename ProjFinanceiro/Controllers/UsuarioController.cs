using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjFinanceiro.Models;

namespace ProjFinanceiro.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }


        public IActionResult ValidarLogin(UsuarioModel usuario) {

            bool login = usuario.ValidarLogin();
            if(login)
            {
                return RedirectToAction("Index", "Home");
            }else{
                TempData["Mensagem de Login Invalido"] = "Dados de logins invalidos";
                return RedirectToAction("Login");
            }
        }

    }
}