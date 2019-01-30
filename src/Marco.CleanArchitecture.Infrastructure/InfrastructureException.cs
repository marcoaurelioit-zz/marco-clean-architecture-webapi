using System;

namespace Marco.CleanArchitecture.Infrastructure
{
    public class InfrastructureException : Exception
    {
        internal InfrastructureException(string businessMessage) 
            : base(businessMessage) { }
    }
}