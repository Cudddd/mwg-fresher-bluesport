using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bluesport.Common.Responses;
using Bluesport.Services.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bluesport.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _productService.Get();

            ResponseResult response = new ResponseResult()
            {
                data = products
            };
            
            return Ok(response);
        }

        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] int index,[FromQuery]int size)
        {
            var products = await _productService.GetAllPaging(index, size);
            
            ResponseResult response = new ResponseResult()
            {
                data = products
            };
            
            return new OkObjectResult(response);
        }

        [HttpGet("{slug}")]
        public async Task<IActionResult> GetBySlug(string slug)
        {
            var product = await _productService.GetBySlug(slug);

            ResponseResult response = new ResponseResult()
            {
                data = product
            };

            if (product == null)
            {
                response.NotFoundResult(slug);
            }

            return Ok(response);
        }
    }
}