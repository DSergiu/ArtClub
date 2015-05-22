namespace Domain
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int EmployeeNo { get; set; }
        public int Points { get; set; }
        public string Phone { get; set; }
        public bool Gender { get; set; }
        public bool IsBoard { get; set; }
        public bool IsCancelled { get; set; }
        public DateTime CreateAt { get; set; }

        public ICollection<Bid> Bids { get; set; }

        public Member() 
        {
            this.ResetPoints();
            Bids = new List<Bid>();
        }



        public Member AddPoints(int points) 
        {
            this.Points += points;
            return this;
        }

        public Member ResetPoints()
        {
            this.Points = 0;
            return this;
        }

        public Member SetIsBoard(bool isboard)
        {
            this.IsBoard = isboard;
            return this;
        }

        public Member SetIsCancelled(bool iscancelled)
        {
            this.IsCancelled = iscancelled;
            return this;
        }

        public Member SetGender(bool gender)
        {
            this.Gender = gender;
            return this;
        }

        public Member SetEmployeeNo(int employeeNo)
        {
            this.EmployeeNo = employeeNo;
            return this;
        }

        public Member SetEmail(string email) 
        {
            Regex regex = new Regex(@"[\w-.]{2,}@ucn.dk");
            Match match = regex.Match(email);

            if (!match.Success)
            {
                throw new InvalidMailException();
            }

            this.Email = email;

            return this;
        }

        public Member SetName(string name)
        {
            Regex regex = new Regex(@"^[a-zA-Z\s]{2,40}$");
            Match match = regex.Match(name);

            if (!match.Success)
            {
                throw new InvalidNameException();
            }

            this.Name = name;

            return this;
        }

        public Member SetPhone(string phone)
        {
            Regex regex = new Regex(@"^(\+45|0045)?(\d){8}$");
            Match match = regex.Match(phone); 

            if (!match.Success)
            {
                throw new InvalidPhoneException();
            }

            this.Phone = phone;

            return this;
        }
    }
}
