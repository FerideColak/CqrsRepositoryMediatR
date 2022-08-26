using CqrsRepositoryMediatR.Cqrs.Commands.Requests;
using CqrsRepositoryMediatR.Cqrs.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsRepositoryMediatR.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await _mediator.Send(new GetProductsQueryRequest());
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            await _mediator.Send(new GetProductByIdQueryRequest { Id = id }); ;
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _mediator.Send(new DeleteProductCommandRequest { Id = id});
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, UpdateProductCommandRequest request)
        {
            request.Id = id;
            await _mediator.Send(request);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }
    }
}
