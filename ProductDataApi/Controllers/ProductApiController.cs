using Microsoft.AspNetCore.Mvc;
using ProductDataApi.Data;
using ProductDataApi.Repository;

namespace ProductDataApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductApiController : ControllerBase
    {
        private readonly IProductRepository _iproductRepository;
        public ProductApiController(IProductRepository iproductRepository)
        {
            this._iproductRepository = iproductRepository;
        }
       [HttpGet]
       [Route("/[controller]/[action]")]
       public ActionResult <List<Product>> HomeModel()
        {
            return _iproductRepository.GetAllProducts();

        } 
        [HttpGet]
        [Route("/[controller]/[action]/{id}")]
        public ActionResult<Product> GetById(int id)
        {
            return _iproductRepository.GetProductById(id);
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public void Create(Product product)
        {
             _iproductRepository.CreateProduct(product);
        }
        [HttpPut]
        [Route("/[controller]/[action]")]
        public void Update(Product product)
        {
             _iproductRepository.UpdateProduct(product);
        }
        [HttpDelete]
        [Route("/[controller]/[action]/{id}")]
        public void Delete (int Id)
        {
             _iproductRepository.DeleteProduct(Id);
        }

    }
}