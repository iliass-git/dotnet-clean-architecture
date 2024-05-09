using DemoWebApi.Clean.Architecture.Domain.Common;
namespace DemoWebApi.Clean.Architecture.Domain.Entities;

public sealed class ProductCategoryEntity: BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
}