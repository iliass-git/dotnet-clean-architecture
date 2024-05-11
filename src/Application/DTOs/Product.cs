namespace DemoWebApi.Clean.Architecture.Application.DTOs;
public sealed class Product
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string Description { get; set; }
    public List<ProductCategory> ProductCategories { get; set; }
}
