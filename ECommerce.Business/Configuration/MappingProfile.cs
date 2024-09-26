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
            .ForPath(p => p.ProductItem!.Price, opt => opt.MapFrom(pc => pc.Price))
            .ReverseMap();
    }
}
