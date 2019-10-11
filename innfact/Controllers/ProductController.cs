using System;
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
    public class ProductController : ControllerBase
    {
        private ProductService productService;
        public ProductController(innfactContext _db)
        {
            productService = new ProductService(_db);
        }
        [HttpGet]
        public OutProductsVM GetProduct(Guid productID)
        {
           return productService.GetProduct(productID);
        }
        [HttpGet]
        public IEnumerable<OutAboutProductsVM> GetAboutProducts(Guid productID)
        {
            return productService.GetAboutProducts(productID);
        }
    }
}