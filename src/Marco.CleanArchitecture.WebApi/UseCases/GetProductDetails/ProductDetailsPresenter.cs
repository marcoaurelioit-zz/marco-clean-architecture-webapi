using Marco.CleanArchitecture.Application.UseCases.GetProductDetails;
using Microsoft.AspNetCore.Mvc;

namespace Marco.CleanArchitecture.WebApi.UseCases.GetProductDetails
{
    public sealed class ProductDetailsPresenter
    {
        public IActionResult ViewModel { get; set; }

        public void Populate(ProductOutput output)
        {
            if (output == null)
            {
                ViewModel = new NotFoundResult();
                return;
            }

            ViewModel = new ObjectResult(new ProductDetailsModel(
                output.ProductId,
                output.Name,
                output.Description,
                output.Price,
                output.Available));
        }
    }
}