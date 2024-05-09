namespace DemoWebApi.Clean.Architecture.Application.Mappers;
using DemoWebApi.Clean.Architecture.Domain.Entities;
using DemoWebApi.Clean.Architecture.Application.DTOs;
using AutoMapper;

public class ProductMapper: Profile
{
    public ProductMapper()
    {
        CreateMap<ProductEntity, Product>()
            .ForMember(dest => dest.ProductCategories, opt => opt.MapFrom(src => src.ProductCategories));
        CreateMap<Product, ProductEntity>()
            .ForMember(dest => dest.ProductCategories, opt => opt.MapFrom(src => src.ProductCategories));
    }
}