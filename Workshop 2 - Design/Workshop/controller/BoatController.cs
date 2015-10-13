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

        public void DeleteBoat(int choosenMemberId)
        {
            try
            {                
                List<model.Boat> boatRegister = be.GetBoats(choosenMemberId);
                bv.DisplayBoats(boatRegister);
                int boatNr = bv.AskForBoat("delete");
                if (!be.CheckIfBoatExists(choosenMemberId, boatNr, boatRegister))
                {
                    v.ViewErrorMessage("The boat doesn't exist");
                    v.Continue();
                    return;
                }
                string input = bv.DeleteBoat();
                if (input == "y")
                {
                    be.DeleteBoat(choosenMemberId, boatNr);
                    v.ConfirmMessage("Boat deleted.");
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
                v.ViewErrorMessage("Error. Try again.");
            }
            v.Continue();
        }

        public void EditBoat(int choosenMemberId)
        {
            try
            {                
                List<model.Boat> boatRegister = be.GetBoats(choosenMemberId);
                bv.DisplayBoats(boatRegister);
                int boatNr = bv.AskForBoat("edit");
                if (!be.CheckIfBoatExists(choosenMemberId, boatNr, boatRegister))
                {
                    v.ViewErrorMessage("The boat doesn't exist");
                    v.Continue();
                    return;
                }
                EditBoatLength(choosenMemberId, boatNr);
                EditBoatType(choosenMemberId, boatNr);
            }
            catch
            {
                v.ViewErrorMessage("Editing boat failed. Try again.");
            }            
            v.Continue();
        }

        public void RegisterBoat(int choosenMemberId)
        {
            try
            {
                string boatType = null;
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
                    default: v.ViewErrorMessage("You didn't choose boat type. Try again.");
                        v.Continue();
                        return;
                }

                be.RegisterBoat(choosenMemberId, boatType, length);
                v.ConfirmMessage("Boat added");
            }
            catch
            {
                v.ViewErrorMessage("Registration failed. Try again.");
            }
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
            else if (inputLength == "n")
            {
                return;
            }
            else
            {
                v.ViewErrorMessage("Type 'y' for yes or 'n' for no. Try again.");
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
            else if (inputType == "n")
            {
                return;
            }
            else
            {
                v.ViewErrorMessage("Type 'y' for yes or 'n' for no. Try again.");
                return;
            }
        }
    }
}
