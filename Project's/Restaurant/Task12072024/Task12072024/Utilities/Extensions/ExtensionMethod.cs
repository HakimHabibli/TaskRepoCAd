using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task12072024.Models;

namespace Task12072024.Utilities.Extensions;

public static class ExtensionMethod
{
    public static double Sum(this List<Dish> dishes)
    {
        double sum = 0;
        foreach (Dish item in dishes)
        {
            sum = sum + item.Price;
        }
        return sum;
    }
}
