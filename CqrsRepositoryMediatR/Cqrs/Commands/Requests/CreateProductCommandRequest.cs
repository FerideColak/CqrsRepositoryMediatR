using MediatR;

namespace CqrsRepositoryMediatR.Cqrs.Commands.Requests
{
    public class CreateProductCommandRequest : IRequest<Guid>
    {
        public string Name { get; set; }
        public int Stock { get; set; }
    }
}
