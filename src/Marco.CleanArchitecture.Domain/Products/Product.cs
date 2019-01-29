using Marco.Domain.Core.Models;

namespace Marco.CleanArchitecture.Domain.Products
{
    public class Product : Entity, IAggregateRoot
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}