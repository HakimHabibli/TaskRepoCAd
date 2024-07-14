namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SwicthCase();
        }
        static void SwicthCase() 
        {
            bool result = true;
            Console.WriteLine(result ? "Kaydetme basarili ":"Kaydetme basarisiz");
            Console.WriteLine(result ? "Kaydetme basarili ":"Kaydetme basarisiz");
        }
    }
}
