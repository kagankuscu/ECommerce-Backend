using ECommerce.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductItemsController : ControllerBase
{
    private readonly IProductItemService _productItemService;

    public ProductItemsController(IProductItemService productItemService)
    {
        _productItemService = productItemService;
    }
    [HttpGet(Name = "GetAllProductItems")]
    public async Task<IActionResult> Get()
    {
        return Ok(await _productItemService.GetAllProductItemsAsync());
    }
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        return Ok(await _productItemService.GetProductItemByIdAsync(id));
    }
}
