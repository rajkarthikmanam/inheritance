using System;
using System.Collections.Generic;

namespace OOP_Fall_2025
{
    internal class Library
    {
        private readonly List<Book> _books = new();

        public void AddBook(Book book) => _books.Add(book);

        public void DisplayBooks()
        {
            Console.WriteLine("Books in Library:");
            foreach (var b in _books)
                Console.WriteLine($"Title: {b.Title}, Author: {b.Author}, Available Copies: {b.AvailableCopies}");
            Console.WriteLine();
        }
    }
}
