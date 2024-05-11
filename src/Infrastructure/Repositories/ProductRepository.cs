namespace DemoWebApi.Clean.Architecture.Infrastructure.Repositories;
using DemoWebApi.Clean.Architecture.Application.Interfaces;
using Microsoft.Azure.CosmosRepository;
using Microsoft.Azure.Cosmos;
using DemoWebApi.Clean.Architecture.Domain.Entities;

public class ProductRepository: IProductRepository
{
    private readonly IRepository<ProductEntity> _cosmosRepository;

    public ProductRepository(IRepository<ProductEntity> cosmosRepository)
    {
        _cosmosRepository = cosmosRepository;
    }

    public async Task<IEnumerable<ProductEntity>> GetAllAsync()
    {
        return await _cosmosRepository.GetAsync( x => x.id != Guid.Empty);
    }

    public async Task<ProductEntity> GetByIdAsync(Guid id)
    {
        return await _cosmosRepository.GetAsync(id.ToString());
    }

    public async Task<ProductEntity> AddAsync(ProductEntity product)
    {
        return await _cosmosRepository.CreateAsync(product);
    }

    public async Task<ProductEntity> UpdateAsync(ProductEntity product)
    {
        return await _cosmosRepository.UpdateAsync(product);
    }

    public async void DeleteAsync(Guid id)
    {
        await _cosmosRepository.DeleteAsync(id.ToString());
    }
}