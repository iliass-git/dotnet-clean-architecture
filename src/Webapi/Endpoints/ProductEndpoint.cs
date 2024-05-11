using MediatR;
using Microsoft.AspNetCore.Mvc;
using DemoWebApi.Clean.Architecture.Infrastructure.Queries.Product;
using DemoWebApi.Clean.Architecture.Infrastructure.Commands.Product;

public static class ProductEndpoint
{
    public static void MapProductEndpoints(this IEndpointRouteBuilder app)
    {

        app.MapGet("api/product/{Id:guid}", GetProduct)
            .WithSummary("Get product")
            .WithTags("Product Apis");

        app.MapPost("api/product", CreateProduct)
            .WithSummary("Create product")
            .WithTags("Product Apis");
    }

    private static async Task<IResult> CreateProduct([FromBody] CreateProductCommand command, IMediator _mediator)
    {
        if (command == null)
        {
            return Results.BadRequest();
        }
        try
        {
 
            var product = await _mediator.Send(command);
            return Results.Ok(product);
        }
        catch (Exception ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }
    private static async Task<IResult> GetProduct(Guid Id, IMediator _mediator)
    {
        try
        {
            var product = await _mediator.Send(new GetProductRequest { Id = Id });
            return Results.Ok(product);
        }
        catch (Exception ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }
}