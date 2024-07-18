using Task.BusinessLogic;
using Task.Models;

namespace Task
{
    /*
 Tapşırıq 1: Kitabxana Sistemi
 */
    internal class Program
    {
        static void Main(string[] args)
        {

            LibraryService libraryService = new LibraryService();

            List<Book> books = new List<Book>();
            List<Category> categories = new List<Category>();
            // Kateqoriyalar əlavə etmək
            Category category1 = new Category { Id = 1, Name = "Detektiv", Description = "Detektiv romanlar" };
            Category category2 = new Category { Id = 2, Name = "Elmi-Fantastik", Description = "Elmi-fantastik kitablar" };
            categories.Add(category1);
            categories.Add(category2);

            // Kitablar əlavə etmək
            libraryService.AddBook(books,1, "QaraYaquar", "Elxan Elatli", category1);
            libraryService.AddBook(books, 2, "1984", "George Orwell", category2);
            libraryService.AddBook(books, 3, "Dune", "Frank Herbert", category2);

            // Kitab götürmək
            libraryService.BorrowBook(books,2);

            // Kitabların vəziyyətini göstərmək
            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.Id}, Adi: {book.Name}, Movcuddur: {book.IsAvailable}");
            }
        }
    }
}
