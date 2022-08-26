using AutoMapper;
using CqrsRepositoryMediatR.Cqrs.Commands.Requests;
using CqrsRepositoryMediatR.Cqrs.Commands.Responses;
using CqrsRepositoryMediatR.Entities;
using CqrsRepositoryMediatR.Repositories;
using MediatR;

namespace CqrsRepositoryMediatR.Cqrs.Commands.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, UpdateProductCommandResponse>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public Task<UpdateProductCommandResponse> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var mapRequest = _mapper.Map<Product>(request);
            var product = _productRepository.UpdateProduct(mapRequest);
            var mapResponse = _mapper.Map<UpdateProductCommandResponse>(product);
            return Task.FromResult(mapResponse);
        }
    }
}
