namespace ECommerce.Models.Models;

public class ShoppingCart : BaseModel
{
    public string AppUserId { get; set; } = null!;

    public AppUser? AppUser { get; set; }
}
