namespace ECommerce.Models.Models;

public class ShoppingCartItem : BaseModel
{
    public int ShoppingCardId { get; set; }
    public int ProductItemId { get; set; }
    public int Quantity { get; set; }

    public ShoppingCart? ShoppingCart { get; set; }
    public ProductItem? ProductItem { get; set; }
}
