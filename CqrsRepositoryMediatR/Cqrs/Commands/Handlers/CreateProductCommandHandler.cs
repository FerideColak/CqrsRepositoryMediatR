using AutoMapper;
using CqrsRepositoryMediatR.Cqrs.Commands.Requests;
using CqrsRepositoryMediatR.Entities;
using CqrsRepositoryMediatR.Repositories;
using MediatR;

namespace CqrsRepositoryMediatR.Cqrs.Commands.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, Guid>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public Task<Guid> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var mapRequest = _mapper.Map<Product>(request);
            var productId = _productRepository.CreateProduct(mapRequest);
            return Task.FromResult(productId);
        }
    }
}
