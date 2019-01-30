using System;

namespace Marco.CleanArchitecture.Application
{
    public class ApplicationException : Exception
    {
        internal ApplicationException(string businessMessage)
       : base(businessMessage) { }
    }
}