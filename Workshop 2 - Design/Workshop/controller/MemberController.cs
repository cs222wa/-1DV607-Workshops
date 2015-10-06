using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.controller
{
    class MemberController
    {
        view.Console v;
        model.Member m;
        controller.BoatController bc;
        List<model.Boat> boatRegister;
        private view.MemberConsole mv;
        private model.MemberEditor me;

        public MemberController()
        {
            v = new view.Console();
            mv = new view.MemberConsole();
            me = new model.MemberEditor();
        }

        public void DeleteMember()
        {
            int choosenMemberId = v.AskForId("delete");
            if ((me.CheckIfMemberExists(choosenMemberId)) == false)
            {
                v.ViewErrorMessage("The member doesn't exist");
                v.Continue();
                return;
            }
            HandleMember(choosenMemberId);
            mv.DeleteMember();
            string input = Console.ReadLine();
            if (input == "y")
            {
                me.DeleteMember(choosenMemberId);
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
                    mv.ViewSpecificMember(member);
                }

            }
        }

        public void EditMemberName(int choosenMemberId)
        {
            mv.IfEditName();
            string inputName = Console.ReadLine();
            if (inputName == "y")
            {
                mv.EditName();
                string name = Console.ReadLine();
                me.EditMemberName(choosenMemberId, name);
                v.ConfirmMessage("Membername changed.");
            }
            else
            {
                return;
            }

        }

        public void EditMemberPN(int choosenMemberId)
        {
            mv.IfEditPN();
            string inputPN = Console.ReadLine();
            if (inputPN == "y")
            {
                mv.EditPN();
                string pn = Console.ReadLine();
                me.EditMemberPN(choosenMemberId, pn);
                v.ConfirmMessage("Personal identity number changed.");
            }
            else
            {
                return;
            }
            v.Continue();
        }


        public void EditMember()
        {
            int choosenMemberId = v.AskForId("edit");
            if ((me.CheckIfMemberExists(choosenMemberId)) == false)
            {
                v.ViewErrorMessage("The member doesn't exist");
                v.Continue();
                return;
            }
            HandleMember(choosenMemberId);
            EditMemberName(choosenMemberId);
            EditMemberPN(choosenMemberId);
        }

        public int GetMemberId(string prompt)
        {
            return 0;
        }

        public void ListMembers()
        {
            v.ChooseListType();
            int listType = int.Parse(Console.ReadLine());
            mv.ListMembers(boatRegister, listType);
            v.Continue();
        }
        
        public void RegisterMember()
        {
            mv.RegisterName();
            string name = System.Console.ReadLine();
            mv.RegisterPersonalIdentityNumber();
            string personalIdentityNumber = System.Console.ReadLine();

            me.RegisterMember(name, personalIdentityNumber);

            v.ConfirmMessage("Member registered"); // + "Id: " + id + ", Name: " + name + ", Personal identity number: " + personalIdentityNumber);
            v.Continue();
        }

        public void ViewMember()
        {
            int choosenMemberId = v.AskForId("view");
            if ((me.CheckIfMemberExists(choosenMemberId)) == false)
            {
                v.ViewErrorMessage("The member doesn't exist");
                v.Continue();
                return;
            }
            HandleMember(choosenMemberId);
            v.Continue();
        }
    }
}
