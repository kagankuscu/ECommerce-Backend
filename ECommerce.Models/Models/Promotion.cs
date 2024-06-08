namespace ECommerce.Models.Models;

public class Promotion : BaseModel
{
    public string name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public int DiscountRate { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public ICollection<PromotionProductCategoryRel> PromotionProductCategory { get; set; } = [];
}
