namespace ECommerce.Models.Models;

public class UserPaymentMethod : BaseModel
{
    public string AppUserId { get; set; } = null!;
    public int PaymentTypeId { get; set; }
    public string Provider { get; set; } = string.Empty;
    public string AccountNumber { get; set; } = string.Empty;
    public DateTime ExpiryDate { get; set; }
    public bool IsDefault { get; set; }

    public AppUser? AppUser { get; set; }
    public PaymentType? PaymentType { get; set; }
}
