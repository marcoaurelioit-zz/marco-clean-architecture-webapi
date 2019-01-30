using Marco.CleanArchitecture.Domain.ValueObjects;
using System;

namespace Marco.CleanArchitecture.Domain.Products
{
    public class Product : IEntity, IAggregateRoot
    {     
        public Guid Id { get; private set; }
        public Name Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public bool Available { get; private set; }

        public Product(Guid id, Name name, string description, decimal price, bool available)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Available = available;
        }
    }
}