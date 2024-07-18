using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models
{
    /*
    Kitab (Book) Class:
    Id
    Title
    Author
    Category
    IsAvailable (Kitabın mövcud olub-olmadığını göstərir)

     */
    public class Book : BaseEntity
    {
        public string Author { get; set; }
        public bool IsAvailable { get; set; } = true;
        public Category Category { get; set; }
        public Book(int id, string name, string author, Category category):base(id,name)
        {
            Author = author;
            Category = category;
            IsAvailable = true;
        }
    }
 

}
