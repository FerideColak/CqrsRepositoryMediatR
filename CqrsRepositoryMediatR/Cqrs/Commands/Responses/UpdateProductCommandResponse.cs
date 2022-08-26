namespace CqrsRepositoryMediatR.Cqrs.Commands.Responses
{
    public class UpdateProductCommandResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
    }
}
