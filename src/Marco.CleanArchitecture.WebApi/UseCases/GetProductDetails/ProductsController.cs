using Marco.CleanArchitecture.Application.UseCases.GetProductDetails;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Marco.CleanArchitecture.WebApi.UseCases.GetProductDetails
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IGetProductDetailsUseCase _getProductDetailsUseCase;
        private readonly ProductDetailsPresenter _presenter;

        public ProductsController(IGetProductDetailsUseCase getProductDetailsUseCase, ProductDetailsPresenter presenter)
        {
            _getProductDetailsUseCase = getProductDetailsUseCase;
            _presenter = presenter;
        }

        /// <summary>
        /// Get product details
        /// </summary>
        [HttpGet("{productId}", Name = "GetProduct")]
        public async Task<IActionResult> Get(Guid productId)
        {
            ProductOutput output = await _getProductDetailsUseCase.Execute(productId);
            _presenter.Populate(output);
            return _presenter.ViewModel;
        }
    }
}