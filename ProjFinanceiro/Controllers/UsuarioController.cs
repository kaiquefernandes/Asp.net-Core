using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjFinanceiro.Models;

namespace ProjFinanceiro.Controllers
{
    public class UsuarioController : Controller
    {   
        [HttpGet]
        public IActionResult Login(int? id)
        {
            if (id != null) {
                if (id == 0) {
                    HttpContext.Session.SetString("IdUsuarioLogado", string.Empty);
                    HttpContext.Session.SetString("NomeUsuarioLogado", string.Empty);
                }
            }
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(UsuarioModel usuario)
        {
            if (ModelState.IsValid) {
                usuario.RegistrarUsuario();
                return RedirectToAction("Sucesso");
            }
            return View();
        }

        public IActionResult Sucesso() {
            return View();

        }

        public IActionResult Menu()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }


        public IActionResult ValidarLogin(UsuarioModel usuario) {

            bool login = usuario.ValidarLogin();
            if(login)
            {
                HttpContext.Session.SetString("NomeUsuarioLogado", usuario.Nome);
                HttpContext.Session.SetString("IdUsuarioLogado", usuario.ID.ToString());

                return RedirectToAction("Menu", "Home");
            }else{
                TempData["Mensagem de Login Invalido"] = "Dados de logins invalidos";
                return RedirectToAction("Login");
            }
        }

    }
}