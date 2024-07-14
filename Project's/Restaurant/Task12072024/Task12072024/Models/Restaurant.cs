using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12072024.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Dish> Menu { get; set; }
        public List<Order> Orders { get; set; }
        public Restaurant(int id,string name)
        {
            Id = id;
            Name = name;
        }
        public Restaurant(int id, string name, string address, List<Dish> menu, List<Order> orders) : this(id, name)
        {
            Address = address;
            Menu = menu;
            Orders = orders;
        }
        public void AddDish(Dish dish) 
        {
            Menu.Add(dish);
            Console.WriteLine("Successfull");
        }
        public void AddOrder(Order order) 
        {
            Orders.Add(order); 
        }
        public Order? GetOrdeById(int id) 
        {
            Order? order = Orders.SingleOrDefault(o => o.Id == id);
            //Order order1 = Orders.Find(o => o.Id == id);
            return order;
        }
    }
}
