using AutoMapper;
using CatShop.Model.Models;
using CatShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatShop.Web.mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
            Mapper.CreateMap<ProductCategory, ProductCategoryViewModel>();
            Mapper.CreateMap<Product, ProductViewModel>();
            Mapper.CreateMap<ProductTag, ProductTagViewModel>();
        }
    }
   
}