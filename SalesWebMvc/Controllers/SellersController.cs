using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using SalesWebMvc.Models.ViewModels;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;

        public SellersController(SellerService sellerService,DepartmentService departmentService)
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }

        public IActionResult Index()//chamei o controlador
        {
            var list = _sellerService.FindAll();//O controlador acessou meu model, pegou dado na lista vai encaminhar esses dados ´p/minha view|retorna uma lista de seller
            return View(list);
        }

        public IActionResult Create()//Metodo create|Vai abrir o formulario p/cadastrar vendedor
        {
            //carregar dptos
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel { Departments = departments };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller); //inseriu o vendedor
            return RedirectToAction(nameof(Index));
        }


    }
}