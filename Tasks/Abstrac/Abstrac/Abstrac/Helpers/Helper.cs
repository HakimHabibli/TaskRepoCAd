using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Abstrac.Helpers
{
  public static class Helper
{
    public static void WriteConsole<T>(this T entity, int indent = 0)
    {
        Type type = entity.GetType();
        PropertyInfo[] properties = type.GetProperties(); 
        string indentString = new string(' ', indent * 4);

        foreach (PropertyInfo property in properties)
        {
            object value = property.GetValue(entity);
            
            if (value != null && !property.PropertyType.IsPrimitive && property.PropertyType != typeof(string))
            {
                // Əgər xüsusiyyət bir obyekt isə, xüsusiyyət adını yaz və daha dərinə get
                Console.WriteLine($"{indentString}{property.Name}:");
                value.WriteConsole(indent + 1); // Rekursiv çağırış
            }
            else
            {
                // Əgər xüsusiyyət sadə bir tip və ya string isə, dəyəri yaz
                Console.WriteLine($"{indentString}{property.Name}: {value}");
            }
        }
    }
}
}
