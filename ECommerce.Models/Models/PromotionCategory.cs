namespace ECommerce.Models.Models;

public class PromotionProductCategoryRel
{
    public int PromotionId { get; set; }
    public Promotion? Promotion { get; set; }
    public int ProductCategoryId { get; set; }
    public ProductCategory? ProductCategory { get; set; }
}
