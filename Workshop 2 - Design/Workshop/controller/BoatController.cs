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
        private model.BoatEditor be;
        model.MemberEditor me;
        

        public BoatController()
        {
            v = new view.Console();
            bv = new view.BoatConsole();
            be = new model.BoatEditor(); 
            me = new model.MemberEditor();
        }


        public void DeleteBoat()
        {
            int choosenMemberId = v.AskForId("delete boat");
            if ((me.CheckIfMemberExists(choosenMemberId)) == false)
            {
                v.ViewErrorMessage("The member doesn't exist");
                v.Continue();
                return;
            }
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

        public void EditBoat()
        {
            int choosenMemberId = v.AskForId("edit boat for");
            if ((me.CheckIfMemberExists(choosenMemberId)) == false)
            {
                v.ViewErrorMessage("The member doesn't exist");
                v.Continue();
                return;
            }

            EditBoatLength(choosenMemberId);
            EditBoatType(choosenMemberId);
        }

        public void RegisterBoat()
        {
            string boatType = null;
            int choosenMemberId = v.AskForId("register boat for");
            if ((me.CheckIfMemberExists(choosenMemberId)) == false)
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

        private void EditBoatLength(int choosenMemberId)
        {
            bv.IfEditBoatLength();
            string inputLength = Console.ReadLine();
            if (inputLength == "y")
            {
                bv.EditBoatLength();
                double length = double.Parse(Console.ReadLine());
                be.EditBoatLength(choosenMemberId);
                v.ConfirmMessage("Boat length changed.");
            }
            else
            {
                return;
            }
        }
        private void EditBoatType(int choosenMemberId)
        {
            bv.IfEditBoatType();
            string inputType = Console.ReadLine();
            if (inputType == "y")
            {
                bv.EditBoatType();
                double length = double.Parse(Console.ReadLine());
                be.EditBoatType(choosenMemberId);
                v.ConfirmMessage("Boattype changed.");
            }
            else
            {
                return;
            }
        }
    }
}
