using ECommerce.Models.DataShape;

namespace ECommerce.Business.Utils.Abstract;

public interface IDataShaper<T>
{
    IEnumerable<ShapedEntity> ShapeData(IEnumerable<T> entities, string fieldsString);
    ShapedEntity ShapeData(T entity, string fieldsString);
}