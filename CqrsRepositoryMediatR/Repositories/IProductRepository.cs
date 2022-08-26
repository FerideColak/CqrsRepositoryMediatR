using CqrsRepositoryMediatR.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CqrsRepositoryMediatR.Repositories
{
    public interface IProductRepository
    {
        Guid CreateProduct(Product product);
        Product GetProductById(Guid id);
        bool DeleteProduct(Guid id);
        List<Product> GetAllProducts();
        Product UpdateProduct(Product product);
    }
}
