namespace DemoWebApi.Clean.Architecture.WebApi.Extensions;
using DemoWebApi.Clean.Architecture.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using DemoWebApi.Clean.Architecture.Application.Mappers;
using AutoMapper;
public static class ServiceCollectionExtensions
{
    public static void RegisterAppService(this IServiceCollection services)
    {
        
        services.AddCosmosRepository(
            options =>
            {
                options.CosmosConnectionString = "< connection string >";
                options.ContainerId = "data-store";
                options.DatabaseId = "samples";
            });
        services.AddAutoMapper(typeof(ProductMapper), typeof(ProductCategoryMapper));
        //services.AddScoped<ITestManager, TestManager>();
        //services.AddScoped<ITestService, TestService>();
    }
}