using ProductDataApi.Data;

namespace ProductDataApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _proudctDbContext;
        public ProductRepository(ProductDbContext proudctDbContext)
        {
            this._proudctDbContext = proudctDbContext;
        }

        public void CreateProduct(Product product)
        {
            if (product != null)
            {
                _proudctDbContext.Products.Add(product);
                _proudctDbContext.SaveChanges();
            }
        }

        public void DeleteProduct(int id)
        {
            var product = _proudctDbContext.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _proudctDbContext.Products.Remove(product);
                _proudctDbContext.SaveChanges();
            }

        }

        public List<Product> GetAllProducts()
        {
            return _proudctDbContext.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return _proudctDbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public void UpdateProduct(Product product)
        {
            if (product != null)
            {
                _proudctDbContext.Products.Update(product);
                _proudctDbContext.SaveChanges();
            }
        }
    }
}
