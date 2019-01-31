using Marco.CleanArchitecture.Application.Repositories;
using Marco.CleanArchitecture.Domain.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Marco.CleanArchitecture.Infrastructure.EntityFrameworkDataAccess.Repositories
{
    public class ProductRepository : IProductReadOnlyRepository, IProductWriteOnlyRepository
    {
        private readonly DataAccessEntityFrameworkContext _context;

        public ProductRepository(DataAccessEntityFrameworkContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddAsync(Product product)
        {
            Entities.Product productEntity = new Entities.Product()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Available = product.Available
            };

            await _context.Products.AddAsync(productEntity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Product product)
        {
            var id = new SqlParameter("@Id", product.Id);
            string deleteSQL = @"DELETE FROM Products WHERE Id = @Id";
            int affectedRows = await _context.Database.ExecuteSqlCommandAsync(deleteSQL, id);
        }

        public async Task<Product> GetAsync(Guid id)
        {
            Entities.Product product = await _context.Products.FindAsync(id);
            Product result = Product.LoadFromDetails(product.Id, product.Name, product.Description, product.Price, product.Available);
            return result;
        }

        public async Task UpdateAsync(Product product)
        {
            Entities.Product productEntity = new Entities.Product()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Available = product.Available
            };

            Entities.Product productOld = await _context.Products.FindAsync(product.Id);

            if (productOld != null)
            {
                _context.Entry(productOld).CurrentValues.SetValues(productEntity);
                await _context.SaveChangesAsync();
            }
        }
    }
}