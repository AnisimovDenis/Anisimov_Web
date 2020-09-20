﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Anisimov.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Anisimov.Infrastructure.Interfaces;

namespace Anisimov.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admins")]
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Productslist()
        {
            var products = _productService.GetProducts(new ProductFilter());
            return View(products);
        }
    }
}
