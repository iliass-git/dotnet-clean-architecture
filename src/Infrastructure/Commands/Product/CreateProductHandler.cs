namespace DemoWebApi.Clean.Architecture.Infrastructure.Commands.Product;
using  DemoWebApi.Clean.Architecture.Application.Interfaces;
using DemoWebApi.Clean.Architecture.Application.DTOs;
using DemoWebApi.Clean.Architecture.Application.Mappers;
using DemoWebApi.Clean.Architecture.Domain.Entities;
using MediatR;
using AutoMapper;

public class CreateProductHandler : IRequestHandler<CreateProductCommand, Product>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;
    public Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        Console.WriteLine("CreateProductHandler.Handle called");
        var productEntity = _mapper.Map<ProductEntity>(request);
        var newProduct =  _productRepository.AddAsync(productEntity);
        return null;
    }
}