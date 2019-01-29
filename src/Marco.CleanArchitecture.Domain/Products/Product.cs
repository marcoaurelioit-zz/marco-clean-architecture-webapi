using System;

namespace Marco.CleanArchitecture.Domain.Products
{
    public class Product : IEntity, IAggregateRoot
    {     
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public bool Available { get; private set; }

        public Product(Guid id, string title, string description, decimal price, bool available)
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price;
            Available = available;
        }
    }
}