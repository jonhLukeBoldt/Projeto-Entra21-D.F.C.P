﻿using DFCP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Metadata;
using BLL;
using BLL.Helper;
//using Projeto_Entra21_DFCP.Models;


namespace Projeto_Entra21_DFCP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Ganhos()
        {
            return View();
        }
        public IActionResult Saldo()
        {
            return View();
        }
        public IActionResult Contas()
        {
            return View();
        }
        public IActionResult Gastos()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult CadastroAPI(Usuario usuario)
        {
            bool validateBool = false;
            CadastrarBLL cadastrar = new CadastrarBLL();
            if(HelpValidate.IsValidName(usuario.Nome) == "")
            {
                validateBool = true;
            }
            else
            {
                //Não sei como fazer, mas se cair nesse else, retorna um alert com essa função HelpValidate.IsValidName(usuario.Nome)
                return RedirectToAction("/Home/Cadastro");
            }
            if(HelpValidate.IsValidEmail(usuario.Email) == "")
            {
                validateBool = true;
            }
            else
            {
                //Não sei como fazer, mas se cair nesse else, retorna um alert com essa função HelpValidate.IsValidEmail(email)
                return RedirectToAction("/Home/Cadastro");
            }
            if (HelpValidate.IsValidPasscode(usuario.Senha) == "")
            {
                validateBool = true;
            }
            else
            {
                //Não sei como fazer, mas se cair nesse else, retorna um alert com essa função HelpValidate.IsValidPasscode(senha)
                return RedirectToAction("/Home/Cadastro");
            }
            if(cadastrar.ValidarUsuario(usuario) == "")
            {
                validateBool = true;
            }
            else
            {
                //Não sei como fazer, mas se cair nesse else, retorna um alert com essa função cadastrar.Validarusuario(nome)
                return RedirectToAction("/Home/Cadastro");
            }
            if(validateBool)
            {
                cadastrar.Inserir(usuario);
            }
            return RedirectToAction("/Home/index");
        }
        public IActionResult GanhosAPI(string nome, double valor, string motivo)
        {
            GanhosBLL ganhos = new GanhosBLL();
            ganhos.CadastrarValor(nome, valor, motivo);
            return RedirectToAction("/Home/Ganhos");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
