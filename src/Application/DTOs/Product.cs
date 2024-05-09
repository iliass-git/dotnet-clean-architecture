namespace DemoWebApi.Clean.Architecture.Application.DTOs;
public sealed class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<ProductCategory> ProductCategories { get; set; }
}
