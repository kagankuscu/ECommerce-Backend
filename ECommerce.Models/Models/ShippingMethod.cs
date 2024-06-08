namespace ECommerce.Models.Models;

public class ShippingMethod : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public float Price { get; set; }
}
