using System.ComponentModel.DataAnnotations.Schema;
namespace ECommerce.Models.Models;
public class ProductCategory : BaseModel
{
    public string CategoryName { get; set; } = string.Empty;
    public ICollection<PromotionProductCategoryRel> PromotionProductCategory { get; set; } = [];
    [ForeignKey(name: "ProductCategoryId")]
    public ProductCategory? ProductCategoryFK { get; set; }
}
