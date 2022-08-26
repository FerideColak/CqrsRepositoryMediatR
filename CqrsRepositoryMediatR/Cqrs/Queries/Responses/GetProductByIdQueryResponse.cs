namespace CqrsRepositoryMediatR.Cqrs.Queries.Responses
{
    public class GetProductByIdQueryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
    }
}
