using System.Security.Cryptography.X509Certificates;
using static System.Reflection.Metadata.BlobBuilder;
namespace Library.Model;

internal class Program
{
    static void Main(string[] args)
    {
        Start();
    }

    private static void Start()
    {
        var library = new Library();
        var orderBooks = new List<Books>();
        Order order = null;
        string command;

        do
        {
            Console.WriteLine("Select the command:\n1 -> Get book by Id.\n2 -> Get list of books." +
                              "\n3 -> Add book to list.\n4 -> Edit book with Id.\n5 -> Delete book with Id" +
                              "\n6 -> Delete all books\n7 -> Get book list by parameters(search).\no -> Create new oreder.");

            Console.Write("\nType number for using command:");
            command = Console.ReadLine();
            command.Trim();

            switch (command)
            {
                case "1":
                    Console.Write("Enter the book Id:");
                    int bookId = Convert.ToInt32(Console.ReadLine());
                    var bookById = library.GetBookById(bookId);

                    if (bookById != null) Console.WriteLine($"{bookById}\n");
                    else Console.WriteLine("Book not found");

                    break;
                case "2":
                    foreach (var bookItem in library.GetAllBook())
                        Console.WriteLine(bookItem.ToString());
                    break;
                case "3":
                    Console.Write("Enter Book Id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter Book Name: ");
                    string newName = Console.ReadLine();
                    Console.Write("Enter Author Name: ");
                    string authorName = Console.ReadLine();
                    Console.Write("Enter Code: ");
                    string code = Console.ReadLine();
                    Console.Write("Enter Page Count: ");
                    int pageCount = int.Parse(Console.ReadLine());
                    Console.Write("Enter Price: ");
                    double price = double.Parse(Console.ReadLine());

                    var newBook = new Books
                    {
                        Id = id,
                        BookName = newName,
                        AuthorName = authorName,
                        Code = code,
                        PageCount = pageCount,
                        Price = price
                    };
                    library.AddBook(newBook);
                    Console.WriteLine("Book added successfully.");
                    break;
                case "4":

                    Console.Write("Enter Book Id to edit: ");
                    int editId = int.Parse(Console.ReadLine());
                    Console.Write("Enter new Book Name (leave blank to keep current): ");
                    string editName = Console.ReadLine();
                    Console.Write("Enter new Author Name (leave blank to keep current): ");
                    string editAuthor = Console.ReadLine();
                    Console.Write("Enter new Code (leave blank to keep current): ");
                    string editCode = Console.ReadLine();
                    Console.Write("Enter new Page Count (leave blank to keep current): ");
                    string editPageCount = Console.ReadLine();
                    Console.Write("Enter new Price (leave blank to keep current): ");
                    string editPrice = Console.ReadLine();


                    bool edited = library.EditBook
                     (
                       editId,
                       string.IsNullOrEmpty(editName) ? null : editName,
                       string.IsNullOrEmpty(editAuthor) ? null : editAuthor,
                       string.IsNullOrEmpty(editCode) ? null : editCode,
                       string.IsNullOrEmpty(editPageCount) ? (int?)null : int.Parse(editPageCount),
                       string.IsNullOrEmpty(editPrice) ? (double?)null : double.Parse(editPrice));


                    if (edited) Console.WriteLine("Book updated successfully.");
                    else Console.WriteLine("Book not found.");


                    break;
                case "5":
                    Console.Write("Enter book Id to Delete:");
                    int deleteId = int.Parse(Console.ReadLine());

                    if (library.RemoveBookById(deleteId)) Console.WriteLine("Book deleted successfully");
                    else Console.WriteLine("Book not found");

                    break;
                case "6":

                    library.RemoveAll();
                    Console.WriteLine("All books deleted successfully");
                    break;
                case "7":
                    Console.Write("Enter book Id,name or code for book list:");
                    string parameter = Console.ReadLine();
                    var books = library.FindAllBooks(parameter);
                    foreach (var book in books)
                        Console.WriteLine(book);

                    break;
                case "o":
                    Console.WriteLine("Add books by their ID. Type 'c' to calculate and complete the order.");
                    while (true)
                    {
                        Console.Write("Enter Book Id to add to the order or 'c' to calculate: ");
                        string input = Console.ReadLine();
                        if (input.ToLower() == "c")
                        {
                            order = new Order(new Random().Next(1, 1000), orderBooks);
                            Console.WriteLine("Order created successfully.");
                            Console.WriteLine(order.ToString());
                            break;
                        }
                        else
                        {
                            int orderBookId;
                            if (int.TryParse(input, out orderBookId))
                            {
                                var book = library.GetBookById(orderBookId);
                                if (book != null)
                                {
                                    orderBooks.Add(book);
                                    Console.WriteLine("Book added to order.");
                                }
                                else Console.WriteLine("Book not found.");
                            }
                            else Console.WriteLine("Invalid input. Please enter a valid Book Id or 'c' to calculate.");

                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid command. Please try again.");
                    break;

            }
            Console.Write("Do you want to use another command (n/y): ");
            command = Console.ReadLine();
            Console.Clear();
        } while (command.ToLower() == "y");


        for (int i = 10 - 1; i >= 0; i--)
        {
            Console.Write($"\rClosing in {i} seconds...");
            Thread.Sleep(1000);
        }
        Environment.Exit(0);
    }

}









