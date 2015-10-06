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
            int choosenMemberId = v.AskForId("delete boat for");
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
                be.DeleteBoat(choosenMemberId);         //fixa
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
            
            bv.AskForBoat("edit");          //??
            EditBoatLength(choosenMemberId);
            EditBoatType(choosenMemberId);
            v.Continue();
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
            float length = bv.RegisterBoatLength();
            int value = bv.RegisterBoatType();

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
            v.ConfirmMessage("Boat added");
            v.Continue();
        }

        private void EditBoatLength(int choosenMemberId)
        {
            string inputLength = bv.IfEditBoatLength();
            if (inputLength == "y")
            {
                float length = bv.EditBoatLength();
                be.EditBoatLength(choosenMemberId, length);
                v.ConfirmMessage("Boat length changed.");
            }
            else
            {
                return;
            }
        }
        private void EditBoatType(int choosenMemberId)
        {
            string inputType = bv.IfEditBoatType();
            if (inputType == "y")
            {
                string type = bv.EditBoatType();
                be.EditBoatType(choosenMemberId, type);
                v.ConfirmMessage("Boattype changed.");
            }
            else
            {
                return;
            }
        }
    }
}
