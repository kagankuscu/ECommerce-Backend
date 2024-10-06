using ECommerce.Models.Models;

namespace ECommerce.Repository.Extension;

public static class ProductItemExtension
{
    public static IQueryable<ProductItem> FilterProductItemsByCategoryName(this IQueryable<ProductItem> productItems, string categoryName)
    {
        if (string.IsNullOrEmpty(categoryName))
        {
            return productItems;
        }
        return productItems.Where(pi => pi.Product!.ProductCategory!.CategoryName.ToLower() == categoryName.ToLower());
    }
    public static IQueryable<ProductItem> FilterProductItemsBetweenByPrice(this IQueryable<ProductItem> productItems, int min, int max)
    {
        return productItems.Where(pi => pi.Price > min).Where(pi => pi.Price < max);
    }
}
