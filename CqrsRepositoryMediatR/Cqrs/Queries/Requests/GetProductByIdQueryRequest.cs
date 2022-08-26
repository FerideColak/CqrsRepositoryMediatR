using CqrsRepositoryMediatR.Cqrs.Queries.Responses;
using MediatR;

namespace CqrsRepositoryMediatR.Cqrs.Queries.Requests
{
    public class GetProductByIdQueryRequest : IRequest<GetProductByIdQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
