namespace DemoWebApi.Clean.Architecture.Application.Interfaces;
using DemoWebApi.Clean.Architecture.Domain.Entities;

public interface IProductRepository
{
    public Task<ProductEntity> GetByIdAsync(Guid id);
    public Task<ProductEntity> AddAsync(ProductEntity product);
    public Task<ProductEntity> UpdateAsync(ProductEntity product);
    public void DeleteAsync(Guid id);
}
