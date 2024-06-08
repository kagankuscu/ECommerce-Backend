namespace ECommerce.Models.Models;

public class UserReview : BaseModel
{
    public string AppUserId { get; set; } = null!;
    public int OrderLineId { get; set; }
    public int RatingValue { get; set; }
    public string Comment { get; set; } = string.Empty;

    public OrderLine? OrderLine { get; set; }
    public AppUser? AppUser { get; set; }
}
