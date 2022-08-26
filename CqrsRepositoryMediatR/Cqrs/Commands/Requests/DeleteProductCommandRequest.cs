using MediatR;

namespace CqrsRepositoryMediatR.Cqrs.Commands.Requests
{
    public class DeleteProductCommandRequest : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
