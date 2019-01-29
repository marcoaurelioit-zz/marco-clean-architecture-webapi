using System;

namespace Marco.CleanArchitecture.Domain
{
    internal interface IEntity
    {
        Guid Id { get; }
    }
}