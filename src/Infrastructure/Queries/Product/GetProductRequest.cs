namespace DemoWebApi.Clean.Architecture.Infrastructure.Queries.Product;
using DemoWebApi.Clean.Architecture.Application.DTOs;
using MediatR;
public class GetProductRequest : IRequest<Product>
{
    public Guid Id { get; set; }

}