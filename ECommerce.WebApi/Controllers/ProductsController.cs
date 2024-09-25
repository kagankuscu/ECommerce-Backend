using ECommerce.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet(Name = "GetAllProducts")]
        // [Authorize]
        public async Task<IActionResult> Get()
        {
            return Ok(await _productRepository.GetAllProductsAsync());
        }
    }
}