using Marco.Exceptions.Core;

namespace Marco.CleanArchitecture.Domain.Products
{
    public class ProductUnavailableException : CoreException
    {
        public override string Key => "ProductUnavailableException";
        public override string Message => "Product unavailable.";
    }
}