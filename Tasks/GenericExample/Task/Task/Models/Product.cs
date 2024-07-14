namespace Task.Models
{
    public class Product :IEntity
    {
        private readonly int _id;
        public Product()
        {
            Id = _id;
            _id++;
        }
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock  { get; set; }
    }
}
