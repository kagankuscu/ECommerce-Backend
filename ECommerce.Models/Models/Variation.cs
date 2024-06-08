namespace ECommerce.Models.Models;

public class Variation : BaseModel
{
    public int ProductCategoryId { get; set; }
    public string Name { get; set; } = string.Empty;

    public ProductCategory? ProductCategory { get; set; }
}
