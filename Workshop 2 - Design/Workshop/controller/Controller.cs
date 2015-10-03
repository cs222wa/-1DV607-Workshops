using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.controller
{
    class Controller
    {
        view.Console v;
        model.MemberRegister mr;
        model.Member m;
       
        public Controller()
        {
            v = new view.Console();
            mr = new model.MemberRegister();
            m = new model.Member();
        }

        public void ChooseFromMenu()
        {            
            while (true)
            {
                Console.Clear();
                v.ViewMenu();
                int value = int.Parse(Console.ReadLine());
                switch (value)
                {
                    case 1: RegisterMember();
                        break;
                    case 2: ListMembers();
                        break;
                    case 3: ViewMember();
                        break;
                    //case 4: m.EditMember();
                    //    break;
                    //case 5: m.DeleteMember();
                    //    break;
                    //case 6: b.RegisterBoat();
                    //    break;
                    case 9: return;                        
                }
            }
        }

        public void RegisterMember()
        {
            v.RegisterName();
            string name = System.Console.ReadLine();
            v.RegisterPersonalIdentityNumber();
            string personalIdentityNumber = System.Console.ReadLine();

            mr.RegisterMember(name, personalIdentityNumber);

            v.ConfirmMessage("Member registered"); // + "Id: " + id + ", Name: " + name + ", Personal identity number: " + personalIdentityNumber);
            v.Continue();        
        }

        public void ListMembers()
        {
            v.ChooseListType();
            int listType = int.Parse(Console.ReadLine());
            List<model.Member> memberRegister = mr.ListMembers();
            v.ListMembers(memberRegister, listType);           
            v.Continue();
        }

        public void ViewMember()
        {
            v.AskForMember("view");
            int choosenMemberId = int.Parse(Console.ReadLine());
            List<model.Member> memberRegister = mr.GetSpecifikMember(choosenMemberId);
            foreach (var member in memberRegister)
            {
                if (member.Id == choosenMemberId)
                {
                    v.ViewSpecificMember(member);
                }
            }
            v.Continue();
        }
    }
}
