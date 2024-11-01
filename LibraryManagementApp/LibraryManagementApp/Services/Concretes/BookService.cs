using LibraryManagementApp.Models;
using LibraryManagementApp.Services.Abstraction;

namespace LibraryManagementApp.Services.Concretes;

public class BookService : IBookService
{
    private readonly List<Book> _books = new List<Book>();
    public void CreateBook(Book book)
    {
        _books.Add(book);
    }

    public void DeleteBook(int id)
    {
        var book = _books.FirstOrDefault(b => b.Id == id);
        if (book != null)
        {
            _books.Remove(book);
        }
    }

    public List<Book> GetAllBook()
    {
        return _books;
    }

    public Book GetBookById(int id)
    {
        return _books.FirstOrDefault(b => b.Id == id);
    }

    public Book GetBookByTitle(string title)
    {
        return _books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }
    public void UpdateBook(Book updatedBook)
    {
        var book = _books.FirstOrDefault(b => b.Id == updatedBook.Id);
        if (book != null)
        {
            book.Title = updatedBook.Title;
            book.PublicationYear = updatedBook.PublicationYear;
            book.BookGenre = updatedBook.BookGenre;
            book.LibraryLocation = updatedBook.LibraryLocation;
        }
    }
}
