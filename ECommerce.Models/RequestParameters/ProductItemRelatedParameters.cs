namespace ECommerce.Models.RequestParameters;

public class ProductItemRelatedParameters
{
    public string CategoryName { get; set; } = string.Empty;
    public float Price { get; set; }
    public int MinPrice { get; set; }
    public int MaxPrice { get; set; }

    public ProductItemRelatedParameters()
    {
        MinPrice = 50;
        MaxPrice = 50;
    }
}
