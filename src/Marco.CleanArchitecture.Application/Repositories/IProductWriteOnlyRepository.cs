using Marco.CleanArchitecture.Domain.Products;
using System.Threading.Tasks;

namespace Marco.CleanArchitecture.Application.Repositories
{
    public interface IProductWriteOnlyRepository
    {
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(Product product);
    }
}