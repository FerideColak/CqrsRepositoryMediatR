using AutoMapper;
using CqrsRepositoryMediatR.Cqrs.Commands.Requests;
using CqrsRepositoryMediatR.Cqrs.Commands.Responses;
using CqrsRepositoryMediatR.Cqrs.Queries.Responses;
using CqrsRepositoryMediatR.Entities;

namespace CqrsRepositoryMediatR.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, UpdateProductCommandResponse>();
            CreateMap<Product, GetProductByIdQueryResponse>();
            CreateMap<Product, GetProductsQueryResponse>();
            CreateMap<CreateProductCommandRequest, Product>();
            CreateMap<UpdateProductCommandRequest, Product>();
        }

    }
}
