namespace CatShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CatShop.Data.CatShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CatShop.Data.CatShopDbContext context)
        {
            createProductCategory(context);
            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new CatShopDbContext()));
            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new CatShopDbContext()));
            ////  This method will be called after migrating to the latest version.

            //var user = new ApplicationUser()
            //{
            //    UserName = "hien",
            //    Email = "hienntm311078@gmail.com",
            //    EmailConfirmed = true,
            //    Birthday = DateTime.Now,
            //    FullName = "Nguyen Thi Minh Hien"
            //};

            //manager.Create(user, "123456$");
            //if (!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole() { Name = "Admin" });
            //    roleManager.Create(new IdentityRole() { Name = "User" });
            //}
            //var adminUser = manager.FindByEmail("hienntm311078@gmail.com");
            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
            ////  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            ////  to avoid creating duplicate seed data. E.g.
            ////
            ////    context.People.AddOrUpdate(
            ////      p => p.FullName,
            ////      new Person { FullName = "Andrew Peters" },
            ////      new Person { FullName = "Brice Lambson" },
            ////      new Person { FullName = "Rowan Miller" }
            ////    );
            ////
        }
        private void createProductCategory(CatShop.Data.CatShopDbContext context)
        {
            if (context.ProductCategorys.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>
                {
                   new ProductCategory() {Name="Đồng hồ", Alias="dong-ho", Status=true },
                    new ProductCategory() { Name = "Trang sức", Alias = "dong-ho", Status = true },
                    new ProductCategory() { Name = "Túi xách", Alias = "dong-ho", Status = true }
                };
                context.ProductCategorys.AddRange(listProductCategory);
                context.SaveChanges();
            }

        }
    }
}
