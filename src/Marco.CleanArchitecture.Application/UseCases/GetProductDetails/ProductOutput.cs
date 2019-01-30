using Marco.CleanArchitecture.Domain.Products;
using System;

namespace Marco.CleanArchitecture.Application.UseCases.GetProductDetails
{
    public sealed class ProductOutput
    {    
        public Guid ProductId { get; }
        public string Name { get; }
        public string Description { get; }
        public decimal Price { get; }
        public bool Available { get; }

        public ProductOutput(Guid productId, string name, string description, decimal price, bool available)
        {
            ProductId = productId;
            Name = name;
            Description = description;
            Price = price;
            Available = available;
        }

        public ProductOutput(Product product)
        {
            ProductId = product.Id;
            Name = product.Name;
            Description = product.Description;
            Price = product.Price;
            Available = product.Available;
        }
    }
}