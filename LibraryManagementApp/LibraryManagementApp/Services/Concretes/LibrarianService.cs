using LibraryManagementApp.Models;
using LibraryManagementApp.Services.Abstraction;

namespace LibraryManagementApp.Services.Concretes
{
    public class LibrarianService : ILibrarianService
    {
        private readonly List<Librarian> _librarians = new List<Librarian>();

        public void CreateLibrarian(Librarian librarian)
        {
            _librarians.Add(librarian);
        }

        public void DeleteLibrarian(int id)
        {
            var librarian = _librarians.FirstOrDefault(l => l.Id == id);
            if (librarian != null)
            {
                _librarians.Remove(librarian);
            }
        }

        public Librarian GetLibrarianById(int id)
        {
            return _librarians.FirstOrDefault(l => l.Id == id);
        }

        public List<Librarian> GetAllLibrarians()
        {
            return _librarians;
        }

        public void UpdateLibrarian(Librarian updatedLibrarian)
        {
            var librarian = _librarians.FirstOrDefault(l => l.Id == updatedLibrarian.Id);
            if (librarian != null)
            {
                librarian.Name = updatedLibrarian.Name;
                librarian.HireDate = updatedLibrarian.HireDate;
            }
        }
    }
}
