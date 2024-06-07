using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

internal class Order
{
    public int Id { get; private set; }
    public List<Books> Books { get; private set; }
    public double TotalPrice { get; private set; }
    public string Date { get; private set; }

    public Order(int id, List<Books> books)
    {
        Id = id;
        Books = books ?? new List<Books>();
        Date = DateTime.Now.ToString("G");
        TotalPrice = CalculateTotalPrice();
    }

    private double CalculateTotalPrice()
    {
        return Books.Sum(book => book.Price);
    }

    public void AddBook(Books book)
    {
        Books.Add(book);
        TotalPrice = CalculateTotalPrice();
    }

    public override string ToString()
    {
        var booksDetails = string.Join(", ", Books.Select(b => b.BookName));
        var booksIDs = string.Join(", ", Books.Select(b => b.Id));
        return $"Order Id: [{booksIDs}], Books: [{booksDetails}], Total Price: {TotalPrice:C}, Date: {Date}";
    }
}

 