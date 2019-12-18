using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()//chamei o controlador
        {
            var list = _sellerService.FindAll();//O controlador acessou meu model, pegou dado na lista vai encaminhar esses dados ´p/minha view|retorna uma lista de seller
            return View(list);
        }


    }
}