using System;
using OOP_Fall_2025;

namespace OOP_Fall_2025_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();

            // Books
            var b1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
            var b2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
            var b3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);

            library.AddBook(b1);
            library.AddBook(b2);
            library.AddBook(b3);

            // Initial display only (Ananya will add patrons + borrowing next)
            library.DisplayBooks();
        }
    }
}
