namespace BismillahApp1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BismillahApp1.Models.CompanyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BismillahApp1.Models.CompanyDbContext context)
        {
            context.Brands.AddOrUpdate(new Models.Brand() { BrandID = 1, BrandName = "Samsung" });
            context.Categories.AddOrUpdate(new Models.Category() { CategoryID = 1, CategoryName = "Electronics" });
            context.Products.AddOrUpdate(new Models.Product() { ProductID = 1, ProductName = "Samsung Galaxy Mobile", CategoryID = 1, DateOfPurchase = DateTime.Now, Active = true, BrandID = 1, photo = null, Price = 10000, AvailabilityStatus = "InStock" });
        }
    }
}
