using System.Reflection;
using ECommerce.Business.Utils.Abstract;
using ECommerce.Models.DataShape;

namespace ECommerce.Business.Utils.Concrete;

public class DataShaper<T> : IDataShaper<T> where T : class
{
    public PropertyInfo[] Properties { get; set; }
    public DataShaper()
    {
        Properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
    }

    public IEnumerable<ShapedEntity> ShapeData(IEnumerable<T> entities, string fieldsString)
    {
        var requiredFields = GetRequiredProperties(fieldsString);
        return FetchData(entities, requiredFields);
    }

    public ShapedEntity ShapeData(T entity, string fieldsString)
    {
        var requiredFields = GetRequiredProperties(fieldsString);
        return FetchDataForEntity(entity, requiredFields);
    }

    private IEnumerable<PropertyInfo> GetRequiredProperties(string fieldsString)
    {
        var requiredFields = new List<PropertyInfo>();

        if (!string.IsNullOrWhiteSpace(fieldsString))
        {
            var fields = fieldsString.Split(',',  StringSplitOptions.RemoveEmptyEntries);

            foreach (var field in fields)
            {
                var property = Properties.FirstOrDefault(pi => pi.Name.Equals(field.Trim(), StringComparison.InvariantCultureIgnoreCase));

                if (property is null)
                    continue;

                requiredFields.Add(property);
            }
        }
        else
        {
            requiredFields = Properties.ToList();
        }

        return requiredFields;
    }
    private ShapedEntity FetchDataForEntity(T entity, IEnumerable<PropertyInfo> requiredProperties)
    {
        var shapedObject = new ShapedEntity();

        foreach (var property in requiredProperties)
        {
            var objectPropertyValue = property.GetValue(entity);
            shapedObject.Entity.TryAdd(property.Name, objectPropertyValue);
        }

        var obejectProperty = entity.GetType().GetProperty("Id");
        shapedObject.Id = (int)obejectProperty.GetValue(entity);

        return shapedObject;
    }

    private IEnumerable<ShapedEntity> FetchData(IEnumerable<T> entities, IEnumerable<PropertyInfo> requiredProperties)
    {
        var shapedData = new List<ShapedEntity>();

        foreach (var entity in entities)
        {
            var shapedObject = FetchDataForEntity(entity, requiredProperties);
            shapedData.Add(shapedObject);
        }
        return shapedData;
    }
}