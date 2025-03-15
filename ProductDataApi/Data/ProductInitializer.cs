using Microsoft.EntityFrameworkCore;

namespace ProductDataApi.Data
{
    public class ProductInitializer
    {
        private readonly ModelBuilder _modelBuilder;
        public ProductInitializer(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            _modelBuilder.Entity<Product>().HasData(
          new Product
          {
              Id = 1,
              Name = "Yechzie jdid",
              ProductType = ProductType.Iphone,
              Price = 300,
              Description = "bla bla bla",
              Datetime = DateTime.Now,
          },
                new Product
                {
                    Id = 2,
                    Name = "iphone13",
                    ProductType = ProductType.Iphone,
                    Price = 400,
                    Description = "bla bla bla",
                    Datetime = DateTime.Now,
                },
                new Product
                {
                    Id = 3,
                    Name = "iphone14",
                    ProductType = ProductType.Iphone,
                    Price = 500,
                    Description = "bla bla bla",
                    Datetime = DateTime.Now,
                });
          var model=  _modelBuilder.Entity<Product>();

        }
    }
}
