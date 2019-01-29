using Marco.CleanArchitecture.Domain.Products;
using System;
using System.Threading.Tasks;

namespace Marco.CleanArchitecture.Application.Repositories
{
    public interface IProductReadOnlyRepository
    {
        Task<Product> GetAsync(Guid id);
    }
}