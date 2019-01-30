using Marco.Exceptions.Core;

namespace Marco.CleanArchitecture.Domain.ValueObjects
{
    public class NameNotEmptyException : CoreException
    {
        public override string Key => "NameNotEmptyException";
        public override string Message => "The 'Name' field is required. Supplied an empty value.";
    }
}