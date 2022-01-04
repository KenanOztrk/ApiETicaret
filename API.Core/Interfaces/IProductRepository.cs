﻿using API.Core.DbModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);

        /// <summary>
        /// Tüm ürünleri listeler
        /// </summary>
        /// <returns></returns>
        Task<IReadOnlyList<Product>> GetProductAsync();

    }
}