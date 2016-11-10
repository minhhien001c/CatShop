using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatShop.Web.Infrastructure.Core
{
    public class PaginationSet<T>
    {
        public int Page { set; get; }
        public int TotalPage { set; get; }
        public int TotalCount { set; get; }
        public int Count
        {
            get
            {
                return (Items != null) ? Items.Count() : 0;
            }
        }
        public IEnumerable<T> Items { set; get; }
    }
}