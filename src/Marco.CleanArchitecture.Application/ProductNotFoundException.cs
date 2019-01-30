namespace Marco.CleanArchitecture.Application
{
    public class ProductNotFoundException : ApplicationException
    {
        internal ProductNotFoundException(string message)
         : base(message) { }
    }
}