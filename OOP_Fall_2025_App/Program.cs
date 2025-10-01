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
            library.AddBook(b1); library.AddBook(b2); library.AddBook(b3);

            // Patrons
            var s1 = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
            var s2 = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);
            var st1 = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");
            library.AddPatron(s1); library.AddPatron(s2); library.AddPatron(st1);

            // Initial state
            library.DisplayBooks();
            library.DisplayPatrons();

            // Borrow scenario
            Console.WriteLine("Borrowing Books...");
            if (library.Borrow("S002", "ISBN222", out var msg1)) Console.WriteLine(msg1);
            if (library.Borrow("S001", "ISBN333", out var msg2)) Console.WriteLine(msg2);
            Console.WriteLine();

            // After borrowing
            Console.WriteLine("Books after borrowing:");
            library.DisplayBooks();
        }
    }
}
