namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mağaza yaradılır
            Store store = new Store("Tech Store", "123 Tech Street");

            // Məhsullar əlavə edilir
            Product laptop = new Product("Laptop", 1000.0m, 10);
            Product smartphone = new Product("Smartphone", 500.0m, 20);
            store.AddProduct(laptop);
            store.AddProduct(smartphone);

            // Müştəri əlavə edilir
            Customer customer = new Customer("John Doe");
            store.AddCustomer(customer);

            // Sifariş yaradılır
            Order order = new Order();
            order.AddProduct(laptop);
            order.AddProduct(smartphone);
            store.PlaceOrder("John Doe", order);

            // Sifarişlərin siyahısı və məbləği çap edilir
            foreach (var cust in store.Customers)
            {
                Console.WriteLine($"Customer: {cust.Name}, Orders Count: {cust.Orders.Count}");
                foreach (var ord in cust.Orders)
                {
                    Console.WriteLine($"Order ID: {ord.Id}, Total Amount: {ord.TotalAmount}");
                }
            }
        }
    }
    public class Product 
    {
        private static int _id=1;
        private string _name;
        private decimal _price;
        private int _stock;
        public int Id { get; }
      
        public string Name
        {
            get { return _name; }
            set { Name = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { Price = value; }
        }
        public int Stock
        {
            get { return _stock; }
            set { Stock = value; }
        }
        public Product(string name, decimal price,int stock)
        {
            Id = _id++;
            _name = name;
            _price = price; 
            _stock = stock;
        }


    }
    public class Order 
    {
        private static int _id = 1;
        public int Id { get; set; }
        public List<Product> Products { get; set; }
        public decimal TotalAmount 
        {
            get 
            {
                return Products.Sum(p => p.Price);
            }
        }
        public Order()
        {
            Id = _id++;
            Products = new List<Product>();
        }
        /// <summary>
        /// Yeni Product gelen zaman istifade olunur
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product) 
        {
            Products.Add(product);
        }
        public void SellProduct(string productName, int count)
        {
            var product = Products.FirstOrDefault(p => p.Name == productName);
            if (product == null)
            {
                Console.WriteLine("Product is not found!");
            }
            if (product.Stock > 0 && product.Stock > count)
            {
                product.Stock -= count;
                Console.WriteLine("Product sold!");
            }
            else { Console.WriteLine("Insufficient stock!"); }
        }
        public decimal CalculateAmount(params string[] ProductsNames) 
        {
            decimal totalAmount = 0;
            foreach (var ProductName in ProductsNames)
            {
                var Product = Products.FirstOrDefault(p => p.Name == ProductName);
                if (Product == null)
                {
                    Console.WriteLine("Product is not found");
                }
                else { totalAmount += Product.Price; }
            }
            return totalAmount;
        }
      

    }
    public class Customer 
    {
        private static int _id = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
        public Customer(string name)
        {
            Id= _id++;
            Name = name;
            Orders = new List<Order>(); 
        }
    }
    public class Store 
    {
        public string Name { get; set; }    
        public string Address { get; set; }
        public List<Product> Products { get; set; }
        public List<Customer> Customers { get; set; }
        public Store(string name , string address)
        {
            Name = name;
            Address = address;
            Products = new List<Product>();
            Customers = new List<Customer>();
        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public void AddCustomer(Customer customer) 
        {
            Customers.Add(customer);
        }
        public void PlaceOrder(string customerName, Order order)
        {
            var customer = Customers.FirstOrDefault(p => p.Name == customerName);
            if (customer == null)
            {
                Console.WriteLine("Customer is not found!");
            }
            customer.Orders.Add(order);
            Console.WriteLine("Order is added");
        }
    }
}
