using Marco.CleanArchitecture.Domain.Products;
using System.Threading.Tasks;

namespace Marco.CleanArchitecture.Application.Repositories
{
    public interface IProductWriteOnlyRepository
    {
        Task Add(Product product);
        Task Update(Product product);
        Task Delete(Product product);
    }
}