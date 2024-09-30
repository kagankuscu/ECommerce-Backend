using ECommerce.Business.Abstract;
using ECommerce.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet(Name = "GetAllProducts")]
        // [Authorize]
        public async Task<IActionResult> Get()
        {
            return Ok(await _productService.GetAllProductsAsync());
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            return Ok(await _productService.GetProductByIdAsync(id));
        }
    }
}