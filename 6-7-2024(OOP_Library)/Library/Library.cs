using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Library.Model;

namespace Library;

public class Library
{
    public static List<Books> Books { get; set; }

    public Library()
    {

        Books = new List<Books>();

        var book1 = new Books() { Id = 1, BookName = "The Great Gatsby", AuthorName = "F. Scott Fitzgerald", Code = "B001", PageCount = 218, Price = 15.99 };
        var book2 = new Books() { Id = 2, BookName = "To Kill a Mockingbird", AuthorName = "Harper Lee", Code = "B002", PageCount = 281, Price = 12.99 };
        var book3 = new Books() { Id = 3, BookName = "1984", AuthorName = "George Orwell", Code = "B003", PageCount = 328, Price = 14.99 };
        var book4 = new Books() { Id = 4, BookName = "Pride and Prejudice", AuthorName = "Jane Austen", Code = "B004", PageCount = 279, Price = 9.99 };
        var book5 = new Books() { Id = 5, BookName = "Moby Dick", AuthorName = "Herman Melville", Code = "B005", PageCount = 635, Price = 18.50 };
        var book6 = new Books() { Id = 6, BookName = "War and Peace", AuthorName = "Leo Tolstoy", Code = "B006", PageCount = 1225, Price = 25.99 };
        var book7 = new Books() { Id = 7, BookName = "The Catcher in the Rye", AuthorName = "J.D. Salinger", Code = "B007", PageCount = 214, Price = 10.99 };
        var book8 = new Books() { Id = 8, BookName = "The Hobbit", AuthorName = "J.R.R. Tolkien", Code = "B008", PageCount = 310, Price = 13.99 };
        var book9 = new Books() { Id = 9, BookName = "The Odyssey", AuthorName = "Homer", Code = "B009", PageCount = 541, Price = 17.99 };
        var book10 = new Books() { Id = 10, BookName = "Crime and Punishment", AuthorName = "Fyodor Dostoevsky", Code = "B010", PageCount = 671, Price = 19.99 };


        Books.Add(book1);
        Books.Add(book2);
        Books.Add(book3);
        Books.Add(book4);
        Books.Add(book5);
        Books.Add(book6);
        Books.Add(book7);
        Books.Add(book8);
        Books.Add(book9);
        Books.Add(book10);
    }





    public void AddBook(Books book)
    {
        Books.Add(book);
    }


    public Books? GetBookById(int Id)
    {
        return Books.Where(s => s.Id == Id).FirstOrDefault();
    }

    
    public Books? GetBookByName(string name)
    {
        return Books.Where(s => s.BookName == name).FirstOrDefault();
    }


    public List<Books> GetAllBook()
    {
        return Books;
    }

    public bool EditBook(int id, string? newName, string? newAuthor, string? newCode, int? newPageCount, double? newPrice)
    {
        var book = GetBookById(id);
        if (book != null)
        {
            if (!string.IsNullOrEmpty(newName)) book.BookName = newName;
            if (!string.IsNullOrEmpty(newAuthor)) book.AuthorName = newAuthor;
            if (!string.IsNullOrEmpty(newCode)) book.Code = newCode;
            if (newPageCount.HasValue) book.PageCount = newPageCount.Value;
            if (newPrice.HasValue) book.Price = newPrice.Value;
            return true;
        }
        return false;

    }

    public List<Books> FindAllBooks(string parameter)
    {
        return Books.Where(s => s.BookName.Contains(parameter)  || s.AuthorName.Contains(parameter) || s.Code.Contains(parameter)).ToList();
    }


    public bool RemoveBookById(int id)
    {
        var book = GetBookById(id);
        if (book != null)
        {
            Books.Remove(book);
            return true;
        }
        return false;
    }

    public void RemoveAll()
    {
        Books.Clear();
    }

}
