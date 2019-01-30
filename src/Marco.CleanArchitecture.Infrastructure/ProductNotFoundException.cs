
namespace Marco.CleanArchitecture.Infrastructure
{
    public class ProductNotFoundException : InfrastructureException
    {
        internal ProductNotFoundException(string message) 
            : base(message) { }
    }
}