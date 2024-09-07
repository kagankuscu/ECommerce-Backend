using ECommerce.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly IProductCategoryService _categoryService;

        public CategoriesController(IProductCategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet(Name = "GetAllCategories")]
        // [Authorize]
        public async Task<IActionResult> Get()
        {
            return Ok(await _categoryService.GetAllProductCategoriesAsync());
        }
    }
}