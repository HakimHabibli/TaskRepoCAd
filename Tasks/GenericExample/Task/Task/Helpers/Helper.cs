using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Task.Models;

namespace Task.Helpers
{
    public static class Helper
    {
        public static T Load<T>(T entity) 
            where T : IEntity, new()
        {
            foreach (PropertyInfo prop in entity.GetType().GetProperties()) 
            {
                    if (prop.Name == "Id") { continue; }
                Console.Write($"Lutfen {prop.Name} giriniz :");
                string value = Console.ReadLine();
                #region MyRegion

                //if (prop.PropertyType == typeof(int))
                //{ prop.SetValue(entity, int.Parse(value)); }
                #endregion

                try
                {
                    object convertedValue = Convert.ChangeType(value, prop.PropertyType);
                    prop.SetValue(entity, convertedValue);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Gercersiz deger girdiniz . Hata{ex.Message}");
                    return Load(entity);
                }
            }
            return default;
        }
        public static T WriteToConsole<T>(this T entity) 
        {
            foreach (PropertyInfo property in entity.GetType().GetProperties())
            {

                Console.WriteLine($"{property.Name.PadRight(3)} : {property.GetValue(entity)}");
            }
            return default;
        }
    }
}
