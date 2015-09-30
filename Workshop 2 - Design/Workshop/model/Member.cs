using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Workshop.model
{
    class Member
    {
        private int id;       
        private string name;
        private string personalIdentityNumber;         
        model.MemberRegister mr;

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
                if (String.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentNullException("Personal identity number cannot be empty.");
                    }
                    if (!Regex.IsMatch(value, @"^(\d{6}|\d{8})[-|(\s)]{0,1}\d{4}$"))
                    {
                        throw new ArgumentOutOfRangeException();                        
                    }
                    personalIdentityNumber = value;
            }
        }

        internal model.MemberRegister Mr
        {
            get { return mr; }
            set { mr = value; }
        }


        public Member()
        {
            //id = 0;
            //name = null;
            //personalIdentityNumber = null;
            mr = new MemberRegister();
        }      

        public void RegisterMember(view.Console v)
        {
            v.RegisterName();
            Name = System.Console.ReadLine();
            v.RegisterPersonalIdentityNumber();
            PersonalIdentityNumber = System.Console.ReadLine();

            Id = mr.GetMemberId(id);
            mr.UpdateTextFile(id, name, personalIdentityNumber);
            v.ConfirmMessage("Member registered: " + "Id: " + id + ", Name: " + name + ", Personal identity number: " + personalIdentityNumber);
            v.Continue();
        }

        public void ListMember(view.Console v)
        {
            int listType = v.ChooseListType();
            mr.ListMembers();
            v.Continue();
            //FIXA!                      
        }                                                   

        public void EditMember(view.Console a_view)
        {
            a_view.AskForMemberToEdit();
        }
        
        public void ViewMember(view.Console v)
        {            
            ListMember(v);      //??
            v.AskForMemberToView();
            int choosenMemberId = int.Parse(Console.ReadLine());    
            string choosenMember = mr.GetSpecifikMember(choosenMemberId);
            v.ViewSpecifikMember(choosenMember);                           
        }        
    }       
}
