using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task.Program;

namespace Task.Models
{
    /*

     Category Class:
     Id
     Name
     Description
     Books (kategoriya daxilində olan kitabların siyahısı)

      */
    public class Category:BaseEntity
    {
        
        public string Description { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
        public Category(int id, string name) : base(id, name)
        {
        }

    }
}
