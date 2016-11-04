﻿using CatShop.Data.Infrastructure;
using CatShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatShop.Data.Repositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
    }
    public class ProductCategoryRepository:RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
