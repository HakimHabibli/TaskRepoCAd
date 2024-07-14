using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12072024.Models;

public class Dish
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public Category Category { get; set; }
    public static List<Dish> OldDishes { get; set; }

    #region Ctor
    public Dish(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
    public Dish(int id, string name, double price, Category category) : this(id, name, price)
    {
        Category = category;
    }
    #endregion

    public List<Dish> FindDishesByCategory(List<Dish> dishes,Category category)
    {
        List<Dish> results = dishes.Where(s => s.Category == category).ToList();
        return results;
    }


}
