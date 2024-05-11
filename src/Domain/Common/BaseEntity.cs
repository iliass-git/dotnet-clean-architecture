namespace DemoWebApi.Clean.Architecture.Domain.Common;
using System;
using Newtonsoft.Json;
using Microsoft.Azure.CosmosRepository;
public abstract class BaseEntity: Item
{
    [JsonProperty("id")]
    public Guid id { get; set; }
    public DateTimeOffset DateCreated { get; set; } 
    public DateTimeOffset? DateUpdated { get; set; }
    public DateTimeOffset? DateDeleted { get; set; }
}