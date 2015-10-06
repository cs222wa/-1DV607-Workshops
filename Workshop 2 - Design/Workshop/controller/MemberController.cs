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
            string input = mv.DeleteMember();
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
            mv.ViewSpecificMember(me.GetMember(choosenMemberId));
        }

        public void EditMemberName(int choosenMemberId)
        {
            string inputName = mv.IfEditName();
            if (inputName == "y")
            {
                string name = mv.EditName();
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
            string inputPN = mv.IfEditPN();
            if (inputPN == "y")
            {
                string pn = mv.EditPN();
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

        public void ListMembers()
        {
            int listType = v.ChooseListType();
            mv.ListMembers(me.getListMembers(), listType);
            v.Continue();
        }
        
        public void RegisterMember()
        {
            string name = mv.RegisterName();
            string personalIdentityNumber = mv.RegisterPersonalIdentityNumber();
            
            me.RegisterMember(name, personalIdentityNumber);

            v.ConfirmMessage("Member registered"); 
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
