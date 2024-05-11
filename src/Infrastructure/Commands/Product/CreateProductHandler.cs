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

    public CreateProductHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }
    public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {

        var product = new Product
        {
            
            Name = request.Name,
            Description = request.Description,
            ProductCategories = request.ProductCategories
        };

        var productEntity = _mapper.Map<ProductEntity>(product);
        try
        {
            var result = await  _productRepository.AddAsync(productEntity);
            return _mapper.Map<Product>(result);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}