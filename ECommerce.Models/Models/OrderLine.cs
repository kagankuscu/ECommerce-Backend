namespace ECommerce.Models.Models;

public class OrderLine : BaseModel
{
    public int ProductItemId { get; set; }
    public int ShopOrderId { get; set; }
    public int Quantity { get; set; }
    public float Price { get; set; }

    public ProductItem? ProductItem { get; set; }
    public ShopOrder? ShopOrder { get; set; }
}
