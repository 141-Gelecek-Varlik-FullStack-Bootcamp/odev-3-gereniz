using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gereniz.Database.Entities;
using gereniz.Model;
using gereniz.Model.Product;
using gereniz.Service.Product;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gereniz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        public List<ProductViewModel> Get()
        {
            return _productService.Get();
        }

        [HttpPost]
        public General<ProductViewModel> Insert([FromBody] ProductViewModel productViewModel)
        {
            return _productService.Insert(productViewModel);
        }

        [HttpPut]
        public General<ProductViewModel> Update(int id,[FromBody] ProductViewModel productViewModel)
        {
            return _productService.Update(id,productViewModel);
        }

        [HttpDelete]
        public bool Remove(int id)
        {
            return _productService.Remove(id);
        }
    }
}
