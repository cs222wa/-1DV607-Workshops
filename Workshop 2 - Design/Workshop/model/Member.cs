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

        public Member()
        {
            mr = new model.MemberRegister();
            v = new view.Console();
            b = new model.Boat();
        }      

        public void RegisterMember()
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

        public void ListMember()
        {
            v.ChooseListType();
            ListType(System.Console.ReadLine());
            
            //v.ListAllMembers();
            v.Continue();
            //FIXA!                      
        }

        public void ListType(string type)
        {
            if (int.Parse(type) == 1)
            {
                mr.ListMembersCompact();
            }
            else if (int.Parse(type) == 2)
            {
                mr.ListMembersVerbose();
            }
            else
            {
                //FIXA NÅGOT
            }
            
        }      
        
        public void ViewMember()
        {
            mr.ListMembersCompact();            
            v.AskForMember("view");
            string choosenMember = mr.HandleMember(Console.ReadLine());
            v.ViewSpecifikMember(choosenMember);
            v.Continue(); 
        }

        public void EditMember()
        {
            mr.ListMembersCompact();
            v.AskForMember("edit");
            string choosenMember = mr.HandleMember(Console.ReadLine());
            Console.WriteLine("edit" + choosenMember);                //ta bort
            v.Continue();
        }

        public void DeleteMember()
        {
            mr.ListMembersCompact();
            v.AskForMember("delete");
            string choosenMember = mr.HandleMember(Console.ReadLine());
                        
            v.ConfirmMessage("Do you want to delete this member? (y/n) " + choosenMember);
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("delete");
                //mr.DeleteMember(choosenMember);
                v.Continue();
            }
            else 
            {
                v.Continue();
            }
            
        }
    }       
}
