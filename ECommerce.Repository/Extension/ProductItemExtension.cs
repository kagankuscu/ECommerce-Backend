using ECommerce.Models.Models;
using Microsoft.IdentityModel.Tokens;

namespace ECommerce.Repository.Extension;

public static class ProductItemExtension
{
    public static IQueryable<ProductItem> FilterProductItems(this IQueryable<ProductItem> productItems, string categoryName)
    {
        if (string.IsNullOrEmpty(categoryName))
        {
            return productItems;
        }
        return productItems.Where(pi => pi.Product!.ProductCategory!.CategoryName.ToLower() == categoryName.ToLower());
    }
}
