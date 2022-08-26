using AutoMapper;
using CqrsRepositoryMediatR.Cqrs.Commands.Requests;
using CqrsRepositoryMediatR.Repositories;
using MediatR;

namespace CqrsRepositoryMediatR.Cqrs.Commands.Handlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, bool>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public DeleteProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public Task<bool> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var isDeleted = _productRepository.DeleteProduct(request.Id);
            return Task.FromResult(isDeleted);
        }
    }
}
