namespace DemoWebApi.Clean.Architecture.Infrastructure.Queries.Product;
using  DemoWebApi.Clean.Architecture.Application.Interfaces;
using DemoWebApi.Clean.Architecture.Application.DTOs;
using DemoWebApi.Clean.Architecture.Application.Mappers;
using DemoWebApi.Clean.Architecture.Domain.Entities;
using MediatR;
using AutoMapper;

public class GetProductHandler : IRequestHandler<GetProductRequest, Product>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetProductHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }
    public async Task<Product> Handle(GetProductRequest request, CancellationToken cancellationToken)
    {
        var productEntity = await _productRepository.GetByIdAsync(request.Id);
        return _mapper.Map<Product>(productEntity);
    }
}