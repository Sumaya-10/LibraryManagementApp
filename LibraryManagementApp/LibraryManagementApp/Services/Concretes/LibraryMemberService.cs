using LibraryManagementApp.Models;
using LibraryManagementApp.Services.Abstraction;

namespace LibraryManagementApp.Services.Concretes
{
    public class LibraryMemberService : ILibraryMemberService
    {
        private readonly List<LibraryMember> _members = new List<LibraryMember>();

        public void CreateMember(LibraryMember member)
        {
            _members.Add(member);
        }

        public void DeleteMember(int id)
        {
            var member = _members.FirstOrDefault(m => m.Id == id);
            if (member != null)
            {
                _members.Remove(member);
            }
        }

        public LibraryMember GetMemberById(int id)
        {
            return _members.FirstOrDefault(m => m.Id == id);
        }

        public List<LibraryMember> GetAllMembers()
        {
            return _members;
        }

        public void UpdateMember(LibraryMember updatedMember)
        {
            var member = _members.FirstOrDefault(m => m.Id == updatedMember.Id);
            if (member != null)
            {
                member.Name = updatedMember.Name;
                member.MembershipDate = updatedMember.MembershipDate;
            }
        }
    }
}
