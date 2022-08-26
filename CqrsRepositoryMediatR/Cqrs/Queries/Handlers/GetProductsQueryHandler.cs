using AutoMapper;
using CqrsRepositoryMediatR.Cqrs.Queries.Requests;
using CqrsRepositoryMediatR.Cqrs.Queries.Responses;
using CqrsRepositoryMediatR.Repositories;
using MediatR;

namespace CqrsRepositoryMediatR.Cqrs.Queries.Handlers
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQueryRequest, List<GetProductsQueryResponse>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductsQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public Task<List<GetProductsQueryResponse>> Handle(GetProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var productList = _productRepository.GetAllProducts();
            var mapProducts = _mapper.Map<List<GetProductsQueryResponse>>(productList);
            return Task.FromResult(mapProducts);
        }
    }
}
