using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp_SellersTable.Services;
using WebApp_SellersTable.Models;

namespace WebApp_SellersTable.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
        public IActionResult Create()
        {
            return View(); 
        }
        [HttpPost]
        [ValidateAntiForgeryToken]//Para prevenir ataques aproveitado a autenticação xsrf/csrf attacks
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }        
    }
}
