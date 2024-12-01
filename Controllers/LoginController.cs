using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bibliotec.Contexts;
using Bibliotec.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bibliotec.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        Context context = new Context();

        public IActionResult Index()
        {
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            string? emailInformado = form["Email"];
            string? senhaInformado = form["Senha"];

            Usuario? usuarioBuscado = context.Usuario.FirstOrDefault
            (usuario => usuario.Email == emailInformado && usuario.Senha == senhaInformado);

            //De outra forma:
            // List<Usuario> listaUsuario = context.Usuario.ToList();

            // foreach (Usuario usuario_ in listaUsuario)
            // {
            //     if (usuario_.Email == emailInformado && usuario_.Senha == senhaInformado)
            //     {

            //     } else {
            //         //Usuario não encontrado

            //     }
            // }

            if (usuarioBuscado == null)
            {
                Console.WriteLine($"Dados Inválidos!");
                return LocalRedirect("~/Login");
            } else  {
                Console.WriteLine($"Eba Você Entrou!");
                HttpContext.Session.SetString("UsuarioID", usuarioBuscado.UsuarioID.ToString());
                HttpContext.Session.SetString("Admin", usuarioBuscado.Admin.ToString());
                return LocalRedirect("~/Livro");
                
            }





            return View();
        }
        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}