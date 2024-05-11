namespace DemoWebApi.Clean.Architecture.Infrastructure.Commands.Product;
using DemoWebApi.Clean.Architecture.Application.DTOs;
using MediatR;
public class CreateProductCommand : IRequest<Product>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<ProductCategory> ProductCategories { get; set; }

}