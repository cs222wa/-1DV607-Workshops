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
        controller.BoatController bc;
        List<model.Member> memberRegister;
        List<model.Boat> boatRegister;
       
        public Controller()
        {
            v = new view.Console();
            mr = new model.MemberRegister();
            m = new model.Member();
            bc = new controller.BoatController();
            boatRegister = new List<model.Boat>();
        }

        public void Start()
        {
            memberRegister = mr.ListMembers(m);
            ChooseFromMenu();
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
                    case 4: EditMember();           //ej klar
                        break;
                    case 5: DeleteMember();
                        break;                    
                    case 6: bc.RegisterBoat(memberRegister);
                        break;
                    case 7: bc.EditBoat();
                        break;
                    case 8: bc.DeleteBoat();
                        break;
                    case 9: return;
                    default:
                        break;
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
            v.ListMembers(memberRegister, boatRegister, listType);           
            v.Continue();
        }

        public void ViewMember()
        {            
            int choosenMemberId = v.AskForMember("view");
            HandleMember(choosenMemberId);
            v.Continue();
        }

        public void EditMember()
        {
            int choosenMemberId = v.AskForMember("edit");
            HandleMember(choosenMemberId);
            v.EditMember();
            v.Continue();
        }

        public void DeleteMember()
        {
            int choosenMemberId = v.AskForMember("delete");
            if ((mr.CheckIfMemberExists(choosenMemberId, memberRegister)) == false)
            {
                v.ViewErrorMessage("The member doesn't exist");
                v.Continue();
                return;
            }
            HandleMember(choosenMemberId);
            v.DeleteMember();
            string input = Console.ReadLine();
            if (input == "y")
            {
                mr.DeleteMember(choosenMemberId, memberRegister);
            }
            else
            {                
                return;
            }
            v.ConfirmMessage("Member deleted.");
            v.Continue();
        }

        public void HandleMember(int choosenMemberId)
        {
            
            foreach (var member in memberRegister)                                      
            {
                if (member.Id == choosenMemberId)
                {
                    v.ViewSpecificMember(member);
                }               
            }
        }
    }
}
