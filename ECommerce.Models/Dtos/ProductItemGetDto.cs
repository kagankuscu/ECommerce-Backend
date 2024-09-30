namespace ECommerce.Models.Dtos;

public class ProductItemGetDto
{
    public int Id { get; set; }
    public string? SKU { get; set; }
    public string? ProductImage { get; set; }
    public float Price { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string CategoryName { get; set; } = string.Empty;
    public string Category
    {
        get { return CategoryName; }
    }
}
