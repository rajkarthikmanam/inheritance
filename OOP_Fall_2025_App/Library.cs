using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_Fall_2025
{
    internal class Library
    {
        private readonly List<Book> _books = new();
        private readonly List<Person> _patrons = new();

        public void AddBook(Book book) => _books.Add(book);
        public void AddPatron(Person person) => _patrons.Add(person);

        public void DisplayBooks()
        {
            Console.WriteLine("Books in Library:");
            foreach (var b in _books)
                Console.WriteLine($"Title: {b.Title}, Author: {b.Author}, Available Copies: {b.AvailableCopies}");
            Console.WriteLine();
        }

        public void DisplayPatrons()
        {
            Console.WriteLine("Patrons in Library:");
            foreach (var p in _patrons)
                Console.WriteLine($"Name: {p.Name}, ID: {p.ID}");
            Console.WriteLine();
        }

        public bool Borrow(string patronId, string isbn, out string message)
        {
            var patron = _patrons.FirstOrDefault(p => p.ID == patronId);
            if (patron == null) { message = "Patron not found."; return false; }

            var book = _books.FirstOrDefault(b => b.ISBN == isbn);
            if (book == null) { message = "Book not found."; return false; }

            if (!book.BorrowBook())
            {
                message = $"No copies of '{book.Title}' are available.";
                return false;
            }

            message = $"{patron.Name} borrowed '{book.Title}'";
            return true;
        }
    }
}
