using System;

namespace Marco.CleanArchitecture.Domain
{
    public class DomainException : Exception
    {
        internal DomainException(string businessMessage) 
            : base(businessMessage) { }
    }
}