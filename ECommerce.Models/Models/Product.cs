namespace ECommerce.Models.Models;

public class Product : BaseModel
{
    public int ProductCategoryId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? ProductImage { get; set; }

    public ProductCategory? ProductCategory { get; set; }
}
