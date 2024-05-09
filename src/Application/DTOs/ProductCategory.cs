namespace DemoWebApi.Clean.Architecture.Application.DTOs;

public sealed class ProductCategory
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}