using Task.Helpers;
using Task.Models;

namespace Task;

internal class Program
{
    static void Main(string[] args)
    {
        Category category = new Category();
        Helper.Load(category);
        Category category1 = new Category();
        Helper.Load(category1);

        //Product product = new Product();
        //Helper.Load(product);

        Helper.WriteToConsole(category);
        Helper.WriteToConsole(category1);

        //Helper.WriteToConsole(product);
    }
}
