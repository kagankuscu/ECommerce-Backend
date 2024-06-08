namespace ECommerce.Models.Models;

public class BaseModel
{
    public int Id { get; set; }
    public Guid Guid { get; set; } = Guid.NewGuid();
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateModified { get; set; } = DateTime.Now;
    public bool IsActive { get; set; } = true;
    public bool IsDelete { get; set; } = false;
}
