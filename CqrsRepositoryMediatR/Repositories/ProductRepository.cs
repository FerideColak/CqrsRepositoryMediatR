using CqrsRepositoryMediatR.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CqrsRepositoryMediatR.Repositories
{
    public class ProductRepository : IProductRepository
    {
        List<Product> Products;
        public ProductRepository()
        {
            Products = new List<Product>
            {
                new Product { Id = Guid.NewGuid(), Name = "TV", Stock = 3450},
                new Product { Id = Guid.NewGuid(), Name = "Mouse", Stock = 5000},
                new Product { Id = Guid.NewGuid(), Name = "PC", Stock = 3200},
                new Product { Id = Guid.NewGuid(), Name = "Printer", Stock = 2300},
                new Product { Id = Guid.NewGuid(), Name = "Keyboard", Stock = 4000},
                new Product { Id = Guid.NewGuid(), Name = "Battery", Stock = 1400}
            };
        }

        public Guid CreateProduct(Product product)
        {
            product.Id = Guid.NewGuid();
            Products.Add(product);
            var p = GetProductById(product.Id);
            return p.Id;
        }

        public bool DeleteProduct(Guid id)
        {
            var product = GetProductById(id);
            if (product == null)
                return false;
            Products.Remove(product);
            return true;

        }

        public List<Product> GetAllProducts()
        {
            return Products;
        }

        public Product GetProductById(Guid id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public Product UpdateProduct(Product product)
        {
            var productEntity = GetProductById(product.Id);
            if(productEntity != null)
            {
                productEntity.Id = product.Id;
                productEntity.Name = product.Name;
                productEntity.Stock = product.Stock;
            }
            return productEntity;
        }
    }
}
