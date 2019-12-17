using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models.ViewModels;

namespace SalesWebMvc.Controllers
{
    public class HomeController : Controller //herda da classe controller
    {
        //Todos os métodos retornam o objeto do tipo 'IActionResult' -> resultado de uma ação
        public IActionResult Index()//método index
        {
            return View();
        }

        public IActionResult About()//CONTROLADOR HOME NA AÇÃO ABOUT PASSOU A FRASE P/CHAVE MESSAGE DO OBJETO VIEWDATA
        {
            //Acessou objeto chamado ViewData, esse objeto na chave message vai receber  a frase
            ViewData["Message"] = "Salles Web MVC App from C# Course";//criar app vendas p/nosso curso
          
            ViewData["Professor"] = "Nelio Alves";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
