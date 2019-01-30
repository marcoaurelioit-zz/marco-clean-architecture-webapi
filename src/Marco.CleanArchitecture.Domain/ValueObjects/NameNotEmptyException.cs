namespace Marco.CleanArchitecture.Domain.ValueObjects
{
   public class NameNotEmptyException : DomainException
    {
        internal NameNotEmptyException(string message)
            :base(message)
        {

        }
    }
}