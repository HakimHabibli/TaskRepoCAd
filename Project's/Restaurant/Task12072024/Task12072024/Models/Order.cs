using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12072024.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Dish> Dishes { get; set; }
        public double TotalAmount { get; set; }
        public Order(int id)
        {
            Id = id;
        }
        public Order(int id, List<Dish> dishes, double totalAmount) : this(id)
        {
            Dishes = dishes;
            TotalAmount = totalAmount;
        }
    }
}
