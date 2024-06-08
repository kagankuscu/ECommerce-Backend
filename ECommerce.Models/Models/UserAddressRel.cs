namespace ECommerce.Models.Models;

public class UserAddressRel
{
    public string AppUserId { get; set; } = null!;
    public AppUser? AppUser { get; set; }
    public int AddressId { get; set; }
    public Address? Address { get; set; }

    public bool IsDefault { get; set; }
}
