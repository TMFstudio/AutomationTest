namespace EPShope.Models
{
    public partial record HomeProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime Datetime { get; set; }
        public int ProductType { get; set; }

    }
}
