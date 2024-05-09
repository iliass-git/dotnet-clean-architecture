namespace DemoWebApi.Clean.Architecture.Domain.Common;

using Microsoft.Azure.CosmosRepository;
public abstract class BaseEntity: Item
{
    public Guid Id { get; set; }
    public DateTimeOffset DateCreated { get; set; }
    public DateTimeOffset? DateUpdated { get; set; }
    public DateTimeOffset? DateDeleted { get; set; }
}