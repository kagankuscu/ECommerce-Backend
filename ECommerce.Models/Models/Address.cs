namespace ECommerce.Models.Models;

public class Address : BaseModel
{
    public string AddressLine1 { get; set; } = string.Empty;
    public string? AddressLine2 { get; set; }
    public string City { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public ICollection<UserAddressRel> UserAddressRel { get; set; } = [];
}
