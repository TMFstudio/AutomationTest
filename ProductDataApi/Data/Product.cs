namespace ProductDataApi.Data
{
    public class Product
    {
        public Product()
        {
                
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime Datetime { get; set; }
        public ProductType ProductType { get; set; }


    }
}
