using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Workshop.model
{
    class Member
    {
        private int id;       
        private string name;
        private string personalIdentityNumber;         
        model.MemberRegister mr;
        view.Console v; 
        model.Boat b;
               
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
                name = value;
            }
        }

        public string PersonalIdentityNumber
        {
            get { return personalIdentityNumber; }
            set
            {
                //try
                //{
                    if (String.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentNullException();
                    }
                    if (!Regex.IsMatch(value, @"^(\d{6}|\d{8})[-|(\s)]{0,1}\d{4}$"))
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    personalIdentityNumber = value;
                //}
                //catch (ArgumentException)
                //{
                //    v.ViewErrorMessage("Personal identity number is not valid. Press any key to try again.");                    
                //}
            }
        }        

        

        public Member()                 //??
        {

        }
        public Member(int id, string name, string personalIdentityNumber)
        {
            Id = id;
            Name = name;
            PersonalIdentityNumber = personalIdentityNumber;
            mr = new model.MemberRegister();
            v = new view.Console();
            b = new model.Boat();
        }      

        
    }       
}
