namespace ECommerce.Models.RequestParameters;

public class ProductItemParameters : RequestParameters
{
    public string? CategoryName { get; set; }
    public ProductItemParameters()
    {
        PublicSize = 16;
    }
}
