using System;

namespace Marco.CleanArchitecture.WebApi.UseCases
{
    public sealed class ProductDetailsModel
    {
        public Guid ProductId { get; }
        public string Name { get; }
        public string Description { get; }
        public decimal Price { get; }
        public bool Available { get; }
        public ProductDetailsModel(Guid productId, string name, string description, decimal price, bool available)
        {
            ProductId = productId;
            Name = name;
            Description = description;
            Price = price;
            Available = available;
        }
    }
}