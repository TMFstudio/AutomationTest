using BddWebSUT.Model;

namespace BddWebSUT.Page
{
    public interface ICreateProductPage
    {
        void NewPorduct(Product product);
        public Product GetProductDetails();
    }
}