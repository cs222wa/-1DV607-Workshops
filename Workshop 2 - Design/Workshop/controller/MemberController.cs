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
            List<model.Member> memberRegister = me.DisplayMembers();
            mv.DisplayMembers(memberRegister);
            try
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
                    v.ConfirmMessage("Member deleted.");
                }
                else if (input == "n")
                {
                    return;
                }
                else
                {
                    v.ViewErrorMessage("Type 'y' for yes or 'n' for no. Try again.");
                }                
            }
            catch
            {
                v.ViewErrorMessage("You must fill in member id. Try again.");
            }
            v.Continue();
        }

        public void HandleMember(int choosenMemberId)           //??
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
            List<model.Member> memberRegister = me.DisplayMembers();
            mv.DisplayMembers(memberRegister);
            try
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
            catch
            {
                v.ViewErrorMessage("You must fill in member id. Try again.");
                v.Continue();
            }
        }

        public void ListMembers()
        {
            try
            {
                int listType = v.ChooseListType();
                mv.ListMembers(me.DisplayMembers(), listType);
            }
            catch
            {
                v.ViewErrorMessage("You didn't choose list type. Try again.");
            }
            v.Continue();
        }
        
        public void RegisterMember()
        {
            try
            {
                string name = mv.RegisterName();
                string personalIdentityNumber = mv.RegisterPersonalIdentityNumber();

                me.RegisterMember(name, personalIdentityNumber);
                v.ConfirmMessage("Member registered");
            }
            catch
            {
                v.ViewErrorMessage("Registration failed. Try again.");
            }             
            v.Continue();
        }

        public void ViewMember()
        {
            List<model.Member> memberRegister = me.DisplayMembers();
            mv.DisplayMembers(memberRegister);
            try
            {
                int choosenMemberId = v.AskForId("view");
                if ((me.CheckIfMemberExists(choosenMemberId)) == false)
                {
                    v.ViewErrorMessage("The member doesn't exist");
                    v.Continue();
                    return;
                }
                HandleMember(choosenMemberId);
            }
            catch
            {
                v.ViewErrorMessage("You must fill in member id. Try again.");
            }
            v.Continue();
        }      
    }
}
