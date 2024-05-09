namespace DemoWebApi.Clean.Architecture.Infrastructure.Commands.Product;
using DemoWebApi.Clean.Architecture.Application.DTOs;
using MediatR;

public class CreateProductCommand : IRequest<Product>
{
    public Product Product { get; set; }

}