using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task.Program;

namespace Task.Models
{
    /*
  * 
 Library Class:
 Name
 Address
 Books (kitabxanada olan kitabların siyahısı)
 Categories (kitabxanada olan kategoriyalar)


 Library Methods:
 Kitab əlavə etmək (AddBook)
 Kitab götürmək (BorrowBook)
 Kitabı qaytarmaq (ReturnBook)
 Kitabları kategoriya ilə axtarmaq (FindBooksByCategory)
  */
    public class Library
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Book> Books { get; set; }
        public List<Category> Categories { get; set; } 
        public Library(List<Book> books,List<Category> categories)
        {
            books = new List<Book>();
            categories = new List<Category>();
        }

     
    }

}
