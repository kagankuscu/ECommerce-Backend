using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models.Models;

public class ShopOrder : BaseModel
{
    public int AppUserId { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public int UserPaymentMethodId { get; set; }
    [ForeignKey(name: "ShippingAddressId")]
    public int AddressId { get; set; }
    public int ShippingMethodId { get; set; }
    public int OrderTotal { get; set; }
    public int OrderStatusId { get; set; }

    public Address? Address { get; set; }
    public ShippingMethod? ShippingMethod { get; set; }
    public OrderStatus? OrderStatus { get; set; }
    public UserPaymentMethod? UserPaymentMethod { get; set; }
}
