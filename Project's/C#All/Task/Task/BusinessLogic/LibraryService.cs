using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Task.Models;

namespace Task.BusinessLogic
{
    public class LibraryService
    {
        public void AddBook(List<Book> books,int id, string title, string author, Category category)
        {
            Book book = new Book(id, title, author, category);
            books.Add(book);
            category.Books.Add(book);
            Console.WriteLine(
                $"Kitabin Adi: {book.Name}, Kitabin Yazari: {book.Author}");
        }
        public void BorrowBook(List<Book> books,int bookId)
        {
            Book book = books.FirstOrDefault(b => b.Id == bookId);
            if (book == null) { Console.WriteLine("Book is not found"); }
            if (book.IsAvailable) book.IsAvailable = false;
        }
        public void ReturnBook(List<Book> books, int bookId)
        {
            Book book = books.Find(b => b.Id == bookId);
            if (book == null) { Console.WriteLine("Book is not found"); }
            if (book.IsAvailable == true) { Console.WriteLine("Book is available and book is bookshelf"); }
            else if (book.IsAvailable == false) { book.IsAvailable = true; Console.WriteLine("Process is successful"); }
        }
        public void FinBooksByCategory(List<Category> categories,string categoryName)
        {
            var category = categories.FirstOrDefault(c => c.Name == categoryName);
            if (category is not null)
            {
                foreach (var book in category.Books)
                {
                    Console.WriteLine(
                        $"" +
                        $"ID:{book.Id} " +
                        $"Category:{book.Category} " +
                        $"IsAvailable:{book.IsAvailable} " +
                        $"Title:{book.Name} " +
                        $"Author:{book.Author}");
                }
            }
            else { Console.WriteLine("Not found"); }
        }
    }
}
