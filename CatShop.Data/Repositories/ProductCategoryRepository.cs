using CatShop.Data.Infrastructure;
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
        //IEnumerable<ProductCategory> GetAlias(string alias);
    }
    public class ProductCategoryRepository:RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        //public IEnumerable<ProductCategory> GetAlias(string alias)
        //{
        //    return this.DbContext.ProductCategorys
        //}
    }
}
