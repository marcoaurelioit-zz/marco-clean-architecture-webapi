﻿using System;
using System.Threading.Tasks;

namespace Marco.CleanArchitecture.Application.UseCases.GetProductDetails
{
    public interface IGetProductDetailsUseCase : IUseCase
    {
        Task<ProductOutput> Execute(Guid productId);
    }
}