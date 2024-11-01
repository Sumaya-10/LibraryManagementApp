using LibraryManagementApp.Models;

namespace LibraryManagementApp.Services.Abstraction
{
    public interface ILibraryMemberService
    {
        void CreateMember(LibraryMember member);
        void DeleteMember(int id);
        LibraryMember GetMemberById(int id);
        List<LibraryMember> GetAllMembers();
        void UpdateMember(LibraryMember updatedMember);
    }
}
