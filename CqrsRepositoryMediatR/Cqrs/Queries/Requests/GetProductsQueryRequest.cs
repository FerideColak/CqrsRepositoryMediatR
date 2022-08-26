using CqrsRepositoryMediatR.Cqrs.Queries.Responses;
using MediatR;

namespace CqrsRepositoryMediatR.Cqrs.Queries.Requests
{
    public class GetProductsQueryRequest : IRequest<List<GetProductsQueryResponse>>
    {
    }
}
