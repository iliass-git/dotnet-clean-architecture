namespace DemoWebApi.Clean.Architecture.Application.Mappers;
using DemoWebApi.Clean.Architecture.Domain.Entities;
using DemoWebApi.Clean.Architecture.Application.DTOs;
using AutoMapper;

public class ProductCategoryMapper: Profile
{
    public ProductCategoryMapper()
    {
        CreateMap<ProductCategoryEntity, ProductCategory>();
        CreateMap<ProductCategory, ProductCategoryEntity>();
    }
}