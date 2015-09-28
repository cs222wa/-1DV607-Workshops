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
        private int personalIdentityNumber;
        List<string> memberRegister;              

        public Member()
        {
            id = 0;                                 //ID SKA EJ BÖRJA OM PÅ NOLL!
            name = null;
            personalIdentityNumber = 0;            
            memberRegister = new List<string>();
        }

        public void RegisterMember(model.Member a_member, view.Console a_view, model.Menu a_menu)
        {
                a_member.name = a_view.RegisterName();
                a_member.personalIdentityNumber = a_view.RegisterPersonalIdentityNumber();           
                        
                using (StreamWriter writer = new StreamWriter("memberRegister.txt", true))
                {
                    a_member.id++;    
                    writer.WriteLine(a_member.id + "\t" + a_member.name + "\t" + a_member.personalIdentityNumber);
                    writer.Close();
                    a_view.ConfirmChange("Member registered: " + "Id: " + a_member.id + ", Name: " + a_member.name + ", Personal identity number: " + a_member.personalIdentityNumber);
                    
                    a_menu.ChooseFromMenu(a_member, a_menu);
                }
        }

        public void ListMember(view.Console a_view)
        {
            int listType = a_view.ChooseListType();
            using (StreamReader reader = new StreamReader("memberRegister.txt"))            //Hur visas VerboseList?
            {                                                                               //Antal båtar läggas till i CompactList
                string line = null;                             //Ska denna deklareras högst upp??
                while ((line = reader.ReadLine()) != null)
                {
                    memberRegister.Add(line);
                    a_view.ListAllMembers(line);
                }                                                
            }
            
        }                                                   //Fråga om quit eller ny meny

        public void EditMember(view.Console a_view)
        {
            a_view.AskForMemberToEdit();
        }
        
        public void ViewMember(view.Console a_view)
        {            
                ListMember(a_view);
                int choosenMemberId = a_view.AskForMemberToView();
                a_view.ViewSpecifikMember(memberRegister[choosenMemberId - 1]);
                
            
        }


        
    }
       
}
