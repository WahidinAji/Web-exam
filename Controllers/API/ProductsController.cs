﻿using Microsoft.AspNetCore.Mvc;
using Shop.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Controllers.API {
    public class ProductsController : Controller {
        private readonly IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository) {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetProducts() {
            return this.Ok(this.productRepository.GetAll());
        }
    }
}
