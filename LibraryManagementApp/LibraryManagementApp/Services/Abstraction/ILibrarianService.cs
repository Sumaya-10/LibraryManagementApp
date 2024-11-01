using LibraryManagementApp.Models;

namespace LibraryManagementApp.Services.Abstraction
{
    public interface ILibrarianService
    {
        void CreateLibrarian(Librarian librarian);
        void DeleteLibrarian(int id);
        Librarian GetLibrarianById(int id);
        List<Librarian> GetAllLibrarians();
        void UpdateLibrarian(Librarian updatedLibrarian);
    }
}
