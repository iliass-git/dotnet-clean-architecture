namespace DemoWebApi.Clean.Architecture.WebApi.Extensions;
using Microsoft.Extensions.DependencyInjection;
using DemoWebApi.Clean.Architecture.Application.Mappers;
using DemoWebApi.Clean.Architecture.Application.Interfaces;
using DemoWebApi.Clean.Architecture.Infrastructure.Repositories;
using AutoMapper;
using MediatR;
using System.Reflection;


public static class ServiceCollectionExtensions
{
    public static IServiceCollection  RegisterDependencies(this IServiceCollection services)
    {
        using var serviceProvider = services.BuildServiceProvider();
        var _configuration = serviceProvider.GetService<IConfiguration>();
    
        services.AddCosmosRepository(
            options =>
            {
                options.CosmosConnectionString = _configuration.GetValue<string>("Database:CosmosDB:ConnectionString");
                options.ContainerId = _configuration.GetValue<string>("Database:CosmosDB:ContainerId");
                options.DatabaseId = _configuration.GetValue<string>("Database:CosmosDB:DatabaseId");
            });
        services.AddAutoMapper(typeof(ProductMapper), typeof(ProductCategoryMapper));
        services.AddScoped<IProductRepository, ProductRepository>();
        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(assembly));
        }
        return services;
    }
}