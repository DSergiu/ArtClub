namespace Controlller.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Domain;

    public interface IMemberCtrl
    {
        Member GetMemberById(int memberId);
        ICollection<Member> GetAllMembers();
        Member Login(string email, string password);
        
        void CancelMembership(int memberId);
        int CreateMember(Member member);
        void UpdateMember(Member member);
    }
}
