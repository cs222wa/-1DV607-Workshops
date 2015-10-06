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
            List<model.Boat> boatRegister = be.GetBoats(choosenMemberId);
            bv.DisplayBoats(boatRegister);
            int boatNr = bv.AskForBoat("delete");
            string input = bv.DeleteBoat();
            if (input == "y")
            {
                be.DeleteBoat(choosenMemberId, boatNr);         
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
            List<model.Boat> boatRegister = be.GetBoats(choosenMemberId);
            bv.DisplayBoats(boatRegister);
            int boatNr = bv.AskForBoat("edit");          //??
            EditBoatLength(choosenMemberId, boatNr);
            EditBoatType(choosenMemberId, boatNr);
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

        private void EditBoatLength(int choosenMemberId, int boatNr)
        {
            string inputLength = bv.IfEditBoatLength();
            if (inputLength == "y")
            {
                float length = bv.EditBoatLength();
                be.EditBoatLength(choosenMemberId, boatNr, length);
                v.ConfirmMessage("Boat length changed.");
            }
            else
            {
                return;
            }
        }
        private void EditBoatType(int choosenMemberId, int boatNr)
        {
            string inputType = bv.IfEditBoatType();
            if (inputType == "y")
            {
                string type = bv.EditBoatType();
                be.EditBoatType(choosenMemberId, boatNr, type);
                v.ConfirmMessage("Boattype changed.");
            }
            else
            {
                return;
            }
        }
    }
}
