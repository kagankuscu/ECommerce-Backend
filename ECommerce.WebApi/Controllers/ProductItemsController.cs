using ECommerce.Business.Abstract;
using ECommerce.Models.RequestParameters;
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
    public async Task<IActionResult> Get([FromQuery] ProductItemParameters productItemParameters)
    {
        var productItem = await _productItemService.GetAllProductItemsAsync(productItemParameters);
        return Ok(new { productItem.MetaData, ProductItems = productItem });
    }
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        return Ok(await _productItemService.GetProductItemByIdAsync(id));
    }
    [HttpGet("RelatedProductItems")]
    public async Task<IActionResult> GetRelatedProductItem([FromQuery] ProductItemRelatedParameters productItemRelatedParameters)
    {
        return Ok(await _productItemService.GetRelatedProductItemAsync(productItemRelatedParameters));
    }
}
