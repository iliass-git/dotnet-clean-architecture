
using Microsoft.AspNetCore.Mvc;
using DemoWebApi.Clean.Architecture.Infrastructure.Commands.Product;
using MediatR;

public class ProductController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [Route("api/product")]
    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] CreateProductCommand command)
    {
        if (command == null)
        {
            return BadRequest();
        }
        try
        {
 
            var product = await _mediator.Send(command);
            return Ok(product);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}