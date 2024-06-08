using Microsoft.AspNetCore.Identity;

namespace ECommerce.Models.Models;

public class AppUser : IdentityUser
{
    public ICollection<UserAddressRel> UserAddressRel { get; set; } = [];
}
