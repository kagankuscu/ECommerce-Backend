namespace ECommerce.Models.Models;

public class ProductItem : BaseModel
{
    public int ProductId { get; set; }
    public string? SKU { get; set; }
    public int Stock { get; set; }
    public string? ProductImage { get; set; }
    public float Price { get; set; }

    public ICollection<ProductItemVariationOptionRel> ProductItemVariationOptionRel { get; set; } = [];
    public Product? Product { get; set; }
}
