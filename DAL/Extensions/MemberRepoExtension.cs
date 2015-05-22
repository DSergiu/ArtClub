namespace DAL
{
    using System;
    using System.Linq;

    using Domain;

    public static class MemberRepoExtensions
    {
        public static void CreateMember(this IGenericRepository<Member> _memberRepo, Member member)
        {
            member.CreateAt = DateTime.UtcNow;
            _memberRepo.Insert(member);
        }

        public static Member GetMember(this IGenericRepository<Member> _memberRepo, int memberid)
        {
            return _memberRepo.Find(m => m.Id.Equals(memberid)).FirstOrDefault();
        }

        public static Member GetMemberByEmail(this IGenericRepository<Member> _memberRepo, string email)
        {
            return _memberRepo.Find(m => m.Email.Equals(email)).FirstOrDefault();
        }

        public static IQueryable<Member> GetAllMembers(this IGenericRepository<Member> _memberRepo)
        {
            return _memberRepo.Find(m => true);
        }
    }
}
