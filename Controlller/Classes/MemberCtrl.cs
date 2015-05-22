namespace Controlller.Classes
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    using Domain;
    using Interfaces;
    using DAL;
    using System.Net;

    

    public class MemberCtrl : IMemberCtrl
    {
        public int CreateMember(Member member)
        {
            using (var uow = new EFUnitOfWork())
            {
                Member dbmember = uow.MemberRepository.GetMemberByEmail(member.Email);
                if(dbmember != null)
                    throw new MemberAlreadyRegisterException();

                uow.MemberRepository.CreateMember(member);
                uow.Save();

                return member.Id;
            }
        }


        public Member GetMemberById(int memberId)
        {
            using (var uow = new EFUnitOfWork())
            {
                Member member = uow.MemberRepository.GetMember(memberId);
                return member;
            }

        }

        public ICollection<Member> GetAllMembers()
        {
            using (var uow = new EFUnitOfWork())
            {
                return uow.MemberRepository.GetAllMembers().ToArray();
            }
        }


        public void UpdateMember(Member member)
        {
            using (var uow = new EFUnitOfWork())
            {
                uow.MemberRepository.Update(member);
                uow.Save();
            }
        }


        public void CancelMembership(int memberId)
        {
            using (var uow = new EFUnitOfWork())
            {
                Member member = uow.MemberRepository.GetMember(memberId);
                member.SetIsCancelled(true);

                uow.Save();
            }
        }


        public Member Login(string email, string password)
        {
            Member member = null;
            using (var uow = new EFUnitOfWork())
            {
                member = uow.MemberRepository.GetMemberByEmail(email);
            }

            if(member == null || member.IsBoard == false)
            {
                throw new InvalidMemberException();
            }


            String url = "http://ecampus.ucn.dk/";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.KeepAlive = true;
            request.Accept = @"*/*";

            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                NetworkCredential credential = new NetworkCredential(email, password);
                CredentialCache credentialCache = new CredentialCache();
                credentialCache.Add(new Uri(url), "NTLM", credential);
                request.Credentials = credentialCache;
            }

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                return member;                
            }
            catch (System.Net.WebException)
            {
                throw new InvalidCredentialsException();
            }
        }
    }

}
