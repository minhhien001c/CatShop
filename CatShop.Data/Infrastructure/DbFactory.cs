using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatShop.Data.Infrastructure
{
    public class DbFactory:Disposable, IDbFactory
    {
        CatShopDbContext dbContext;
        public CatShopDbContext Init()
        {
            return dbContext ?? (dbContext = new CatShopDbContext());
        }
        protected virtual void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
