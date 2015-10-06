using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.controller
{
    class MemberController
    {
        view.MemberConsole mv;
        model.MemberEditor me;

        public MemberController()
        {
            mv = new view.MemberConsole();
            me = new model.MemberEditor();
        }

        public void DeleteMember()
        {

        }
        public void EditMember()
        {

        }

        public int GetMemberId(string prompt)
        {
            return 0;
        }

        public void ListMembers()
        {

        }
        
        public void RegisterMember()
        { 

        }

        public void ViewMember()
        {

        }






        /*
        view.Console v; //general console
        model.MemberRegister mr;
        model.Member m;
        controller.BoatController bc;
        List<model.Member> memberRegister;
        List<model.Boat> boatRegister;
       
        public MemberController()
        {
            v = new view.Console();
            mr = new model.MemberRegister();
            m = new model.Member();
            bc = new controller.BoatController();
            boatRegister = new List<model.Boat>();
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
            if ((mr.CheckIfMemberExists(choosenMemberId, memberRegister)) == false)
            {
                v.ViewErrorMessage("The member doesn't exist");
                v.Continue();
                return;
            }
            HandleMember(choosenMemberId);
            v.Continue();
        }

        public void EditMember()
        {
            int choosenMemberId = v.AskForMember("edit");
            if ((mr.CheckIfMemberExists(choosenMemberId, memberRegister)) == false)
            {
                v.ViewErrorMessage("The member doesn't exist");
                v.Continue();
                return;
            }
            HandleMember(choosenMemberId);
            EditMemberName(choosenMemberId);
            EditMemberPN(choosenMemberId);
        }

        public void EditMemberName(int choosenMemberId)
        {
            v.IfEditName();
            string inputName = Console.ReadLine();
            if (inputName == "y")
            {
                v.EditName();
                string name = Console.ReadLine();
                mr.EditMemberName(choosenMemberId, name, memberRegister);
                v.ConfirmMessage("Membername changed.");
            }
            else
            {
                return;
            }

        }

        public void EditMemberPN(int choosenMemberId)
        {
            v.IfEditPN();
            string inputPN = Console.ReadLine();
            if (inputPN == "y")
            {
                v.EditPN();
                string pn = Console.ReadLine();
                mr.EditMemberPN(choosenMemberId, pn, memberRegister);
                v.ConfirmMessage("Personal identity number changed.");
            }
            else
            {
                return;
            }
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
         * */
    }
}
