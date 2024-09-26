using Entities.Models.DataShape;

namespace ECommerce.Models.DataShape;

public class ShapedEntity
{
    public int Id { get; set; }
    public Entity Entity { get; set; }

    public ShapedEntity()
    {
        Entity = new Entity();
    }
}