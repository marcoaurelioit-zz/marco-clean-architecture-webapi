using System;
using System.Threading.Tasks;
using Marco.CleanArchitecture.Application.Repositories;
using Marco.CleanArchitecture.Domain.Products;

namespace Marco.CleanArchitecture.Application.UseCases.GetProductDetails
{
    public sealed class GetProductDetailsUseCase : IGetProductDetailsUseCase
    {
        private readonly IProductReadOnlyRepository _productReadOnlyRepository;

        public GetProductDetailsUseCase(IProductReadOnlyRepository productReadOnlyRepository)
        {
            _productReadOnlyRepository = productReadOnlyRepository ?? throw new ArgumentNullException(nameof(productReadOnlyRepository));
        }

        public async Task<ProductOutput> Execute(Guid productId)
        {
            ProductOutput output = null;

            Product product = await _productReadOnlyRepository.GetAsync(productId);

            if (product != null)
                output = new ProductOutput(product);

            return output;
        }
    }
}