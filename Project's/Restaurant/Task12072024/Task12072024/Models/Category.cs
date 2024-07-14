using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12072024.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Dish> Dishes { get; set; }

        #region Ctor
        public Category(int id , string name)
        {
            Id = id;
            Name = name;
        }
        public Category(int id, string name, string description, List<Dish> dishes) : this(id, name)
        {
            Description = description;
            Dishes = dishes;
        }
        #endregion

    }
}
