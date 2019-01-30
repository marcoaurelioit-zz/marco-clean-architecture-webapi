namespace Marco.CleanArchitecture.Domain.Products
{
    public class ProductUnavailableException : DomainException
    {
        internal ProductUnavailableException(string message)
            :base(message)
        {

        }
    }
}