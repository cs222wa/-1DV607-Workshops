using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.controller
{
    class BoatController
    {
        view.Console v;
        private view.BoatConsole bv;
       // List<model.Member> memberRegister;
        List<model.Boat> boatRegister;
        private model.BoatEditor be;
        model.MemberEditor me;
        string boatType;
        float length;
        

        public BoatController()
        {
            v = new view.Console();
            bv = new view.BoatConsole();
            be = new model.BoatEditor(); 
            me = new model.MemberEditor();
            boatType = null;
            length = 0;
        }


        public void DeleteBoat(List<model.Member> memberRegister)
        {
            int choosenMemberId = v.AskForId("delete boat");
            if ((me.CheckIfMemberExists(choosenMemberId, memberRegister)) == false)
            {
                v.ViewErrorMessage("The member doesn't exist");
                v.Continue();
                return;
            }

            //HandleMember(choosenMemberId);
            bv.DeleteBoat();
            string input = Console.ReadLine();
            if (input == "y")
            {
                //mr.DeleteBoat(choosenMemberId, memberRegister);
            }
            else
            {
                return;
            }
            v.ConfirmMessage("Boat deleted.");
            v.Continue();
        }

        public void EditBoat(List<model.Member> memberRegister)
        {
            int choosenMemberId = v.AskForId("edit boat for");
            if ((me.CheckIfMemberExists(choosenMemberId, memberRegister)) == false)
            {
                v.ViewErrorMessage("The member doesn't exist");
                v.Continue();
                return;
            }
            //HandleMembers();
            EditBoatLength(choosenMemberId);
            EditBoatType(choosenMemberId);
        }

        public void RegisterBoat(List<model.Member> memberRegister)
        {
            int choosenMemberId = v.AskForId("register boat for");
            if ((me.CheckIfMemberExists(choosenMemberId, memberRegister)) == false)
            {
                v.ViewErrorMessage("The member doesn't exist");
                v.Continue();
                return;
            }
            bv.RegisterBoatLength();
            float length = float.Parse(Console.ReadLine());
            bv.RegisterBoatType();

            int value = int.Parse(Console.ReadLine());
            switch (value)
            {
                case 1: boatType = "Sailboat";
                    break;
                case 2: boatType = "Motorsailor";
                    break;
                case 3: boatType = "Kayak/Canoe";
                    break;
                case 4: boatType = "Other";
                    break;
                default:
                    break;
            }

            be.RegisterBoat(choosenMemberId, boatType, length);
            v.Continue();
        }

        public void EditBoatLength(int choosenMemberId)
        {
            bv.IfEditBoatLength();
            string inputLength = Console.ReadLine();
            if (inputLength == "y")
            {
                bv.EditBoatLength();
                double length = double.Parse(Console.ReadLine());
                EditBoatLength(choosenMemberId);
                v.ConfirmMessage("Boat length changed.");
            }
            else
            {
                return;
            }
        }
        public void EditBoatType(int choosenMemberId)
        {
            bv.IfEditBoatType();
            string inputType = Console.ReadLine();
            if (inputType == "y")
            {
                bv.EditBoatType();
                double length = double.Parse(Console.ReadLine());
                EditBoatType(choosenMemberId);
                v.ConfirmMessage("Boattype changed.");
            }
            else
            {
                return;
            }
        }
    }
}
