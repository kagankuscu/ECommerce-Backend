using AutoMapper;
using ECommerce.Models.Dtos;
using ECommerce.Models.Models;

namespace ECommerce.Business.Configuration;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ProductGetDto, Product>()
            .ForPath(p => p.ProductCategory!.CategoryName, opt => opt.MapFrom(pc => pc.CategoryName))
            .ReverseMap();

        CreateMap<ProductItemGetDto, ProductItem>()
            .ForPath(pi => pi.Product!.Name, opt => opt.MapFrom(pi => pi.Name))
            .ForPath(pi => pi.Product!.Description, opt => opt.MapFrom(pi => pi.Description))
            .ForPath(pi => pi.Product!.ProductCategory!.CategoryName, opt => opt.MapFrom(pi => pi.CategoryName))
            .ReverseMap();

        CreateMap<CategoryGetDto, ProductCategory>()
            .ReverseMap();
    }
}
