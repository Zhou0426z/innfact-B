﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using innfact.Models;
using innfact.Service;
using innfact.ViewModels.Out;
namespace innfact.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CollectionController : ControllerBase
    {
        private CategoryService categoryService;
        private ProductService productService;

        public CollectionController(innfactContext _db)
        {
            categoryService = new CategoryService(_db);
            productService = new ProductService(_db);
        }
        [HttpGet]
        public IEnumerable<Categories> GetAsideCategories()
        {
            return categoryService.GetAllCategories();
        }
        [HttpGet]
        public IEnumerable<OutCollectionProductsVM> GetCollectionProducts(string category)
        {
            return productService.GetCollectionProducts(category);
        }
    }
}