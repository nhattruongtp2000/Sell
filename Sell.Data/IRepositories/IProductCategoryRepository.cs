using Sell.Data.Entities;
using Sell.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sell.Data.IRepositories
{
    public interface IProductCategoryRepository :IRepository<ProductCategory,int>
    {
        List<ProductCategory> GetProductCategories(string alias);
    }
}
