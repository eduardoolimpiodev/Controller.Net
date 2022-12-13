using Controllers.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Controllers.Controllers
{   
    // Usa-se a rota vazia apenas em uma controller geralmente na controller inicial.
    [Route("")]
    [Route("gestao")]
    public class HomeController : Controller
    {
        //Todas as rotas dessa controller agora ficam gestao/Index, gestao/Privacy, etc...
        // Para passar um parâmetro não existente em uma rota: 
        ///Home/Index/10?categorias=Teste
        //ou /Home/Index/10?categorias=Teste&categoria2=Teste2 caso haja um segundo parâmetro.
        [Route("")]
        [Route("pagina-inicial")]
        [Route("pagina-inicial/{id:int}/{categoria:guid}")]
        public IActionResult Index(int id, Guid categoria)
        {
            return View();
        }

        [Route("privacidade")]
        [Route("politica-de-privacidade")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro-encontrado")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
