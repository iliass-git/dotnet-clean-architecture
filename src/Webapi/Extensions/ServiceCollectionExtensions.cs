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
        
        services.AddCosmosRepository(
            options =>
            {
                options.CosmosConnectionString = "< connection string >";
                options.ContainerId = "data-store";
                options.DatabaseId = "samples";
            });
        services.AddAutoMapper(typeof(ProductMapper), typeof(ProductCategoryMapper));
        services.AddScoped<IProductRepository, ProductRepository>();
   
       // services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(assembly));
        }
        return services;
    }
}