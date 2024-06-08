namespace ECommerce.Models.Models;

public class VariationOption : BaseModel
{
    public int VariantId { get; set; }
    public string Value { get; set; } = string.Empty;

    public ICollection<ProductItemVariationOptionRel> ProductItemVariationOptionRel { get; set; } = [];
    public Variation? Variation { get; set; }
}
