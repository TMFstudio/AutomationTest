using WebBddSut.Model;

namespace WebBddSut.Page
{
    public interface ICreateProductPage
    {
        void NewPorduct(Product product);
        public Product GetProductDetails(string productName);
    }
}