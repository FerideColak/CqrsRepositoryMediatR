using CqrsRepositoryMediatR.Cqrs.Commands.Responses;
using MediatR;

namespace CqrsRepositoryMediatR.Cqrs.Commands.Requests
{
    public class UpdateProductCommandRequest : IRequest<UpdateProductCommandResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
    }
}
    