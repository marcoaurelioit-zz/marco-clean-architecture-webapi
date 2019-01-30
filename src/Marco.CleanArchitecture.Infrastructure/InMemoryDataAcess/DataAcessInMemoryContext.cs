using Marco.CleanArchitecture.Domain.Products;
using System.Collections.ObjectModel;

namespace Marco.CleanArchitecture.Infrastructure.InMemoryDataAcess
{
    public sealed class DataAcessInMemoryContext
    {
        public Collection<Product> Products { get; set; }

        public DataAcessInMemoryContext()
        {
            Products = new Collection<Product>();
        }
    }
}