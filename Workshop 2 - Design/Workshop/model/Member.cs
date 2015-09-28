using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Workshop.model
{
    class Member
    {
        private int id;
        private string name;
        private int personalIdentityNumber;         //FIXA!
        model.MemberRegister mr;
        
        public Member()
        {
            id = 0;                                 
            name = null;
            personalIdentityNumber = 0;
            mr = new MemberRegister();
        }

        public void RegisterMember(view.Console v)
        {
            v.RegisterName();
            name = System.Console.ReadLine();
            v.RegisterPersonalIdentityNumber();
            personalIdentityNumber = int.Parse(System.Console.ReadLine());

            id = mr.GetMemberId(id);
            mr.UpdateTextFile(id, name, personalIdentityNumber);
            v.ConfirmMessage("Member registered: " + "Id: " + id + ", Name: " + name + ", Personal identity number: " + personalIdentityNumber);
        }

        public void ListMember(view.Console v)
        {
            int listType = v.ChooseListType();
            mr.ListMembers();
            //string line = mr.ListMembers();
            //v.ListAllMembers(line);                        
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
