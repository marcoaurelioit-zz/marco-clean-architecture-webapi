using Marco.CleanArchitecture.Domain.Products;
using System.Collections.ObjectModel;

namespace Marco.CleanArchitecture.Infrastructure.InMemoryDataAcess
{
    public sealed class InMemoryContext
    {
        public Collection<Product> Products { get; set; }

        public InMemoryContext()
        {
            Products = new Collection<Product>();
        }
    }
}