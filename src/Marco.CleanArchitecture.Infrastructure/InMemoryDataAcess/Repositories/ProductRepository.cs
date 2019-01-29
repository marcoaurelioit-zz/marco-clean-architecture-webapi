using Marco.CleanArchitecture.Application.Repositories;
using Marco.CleanArchitecture.Domain.Products;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Marco.CleanArchitecture.Infrastructure.InMemoryDataAcess.Repositories
{
    public class ProductRepository : IProductReadOnlyRepository, IProductWriteOnlyRepository
    {
        private readonly InMemoryContext _context;

        public ProductRepository(InMemoryContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task Add(Product product)
        {
            _context.Products.Add(product);
            await Task.CompletedTask;
        }

        public async Task Delete(Product product)
        {
            Product productOld = _context.Products.SingleOrDefault(x=> x.Id == product.Id);
            _context.Products.Remove(productOld);
            await Task.CompletedTask;
        }

        public async Task<Product> Get(Guid id)
        {
            Product product = _context.Products.SingleOrDefault(x => x.Id == id);
            return await Task.FromResult(product);
        }

        public async Task Update(Product product)
        {
            Product productOld = _context.Products.SingleOrDefault(x=> x.Id == product.Id);
            productOld = product;
            await Task.CompletedTask;
        }
    }
}