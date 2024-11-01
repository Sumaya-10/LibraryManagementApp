
using LibraryManagementApp.Enums;
using LibraryManagementApp.Models;
using LibraryManagementApp.Services.Concretes;

class Program
{
    static void Main(string[] args)
    {
        BookService bookService = new BookService();
        BookService bookService = new BookService();
        Book book1 = new Book("Bocek", 1970) { BookGenre = BookGenre.Fiction };
        Book book2 = new Book("Lazimsiz", 1963) { BookGenre = BookGenre.NonFiction };
        bookService.CreateBook(book1);
        bookService.CreateBook(book2);
        foreach (var book in bookService.GetAllBook())
        {
            Console.WriteLine($"{book.Id}, {book.Title}, {book.PublicationYear}, {book.BookGenre}");
        }
        LibraryMemberService memberService = new LibraryMemberService();
        LibraryMember member1 = new LibraryMember("naciba") { MembershipDate = DateTime.Now };
        memberService.CreateMember(member1);
        foreach (var member in memberService.GetAllMembers())
        {
            Console.WriteLine($"{member.Id}, {member.Name}, {member.MembershipDate}");
        }
        LibrarianService librarianService = new LibrarianService();
        Librarian librarian1 = new Librarian("Sumaya")
        {
            HireDate = DateTime.Now
        };
        librarianService.CreateLibrarian(librarian1);
        foreach (var librarian in librarianService.GetAllLibrarians())
        {
            Console.WriteLine($"{librarian.Id}, {librarian.Name}, {librarian.HireDate}");
        }
        book1.Title = "Yeni Bocek";
        bookService.UpdateBook(book1);
        Console.WriteLine( book1.Title);
        foreach (var book in bookService.GetAllBook())
        {
            Console.WriteLine($"{book.Id}, {book.Title}, {book.PublicationYear}, {book.BookGenre}");
        }
    }
}
