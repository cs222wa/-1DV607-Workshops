using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.controller
{
    class BoatController
    {
        view.BoatConsole bv;
        model.BoatEditor be;

        public BoatController()
        {
            bv = new view.BoatConsole();
            be = new model.BoatEditor();
        }


        public void DeleteBoat()
        {
           
        }

        public void EditBoat()
        {
           
        }

        public void RegisterBoat(int choosenMemberId)
        {
           
        }

        /*
        view.Console v;
        view.BoatConsole bv;
        model.MemberRegister mr;
       
        string boatType;
        float length;

        public BoatController()
        {
            v = new view.Console();
            bv = new view.BoatConsole();
            mr = new model.MemberRegister();
            boatType = null;
            length = 0;
        }
        
        public void RegisterBoat(List<model.Member> memberRegister)
        {
            int choosenMemberId = v.AskForMember("register boat for");
            if ((mr.CheckIfMemberExists(choosenMemberId, memberRegister)) == false)
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

            mr.RegisterBoat(choosenMemberId, length, boatType, memberRegister);
            v.Continue();
        }

        public void EditBoat(List<model.Member> memberRegister)
        {
            int choosenMemberId = v.AskForMember("edit boat for");
            if ((mr.CheckIfMemberExists(choosenMemberId, memberRegister)) == false)
            {
                v.ViewErrorMessage("The member doesn't exist");
                v.Continue();
                return;
            }
            //HandleMembers();
            EditBoatLength(choosenMemberId);
            EditBoatType(choosenMemberId);
        }

        public void EditBoatLength(int choosenMemberId)
        {
            bv.IfEditBoatLength();
            string inputLength = Console.ReadLine();
            if (inputLength == "y")
            {
                bv.EditBoatLength();
                double length = double.Parse(Console.ReadLine());
                mr.EditBoatLength(choosenMemberId);
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
                mr.EditBoatType(choosenMemberId);
                v.ConfirmMessage("Boattype changed.");
            }
            else
            {
                return;
            }
        }

         public void DeleteBoat(List<model.Member> memberRegister)
        {
            int choosenMemberId = v.AskForMember("delete boat");
            if ((mr.CheckIfMemberExists(choosenMemberId, memberRegister)) == false)
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
         * 
         * */
    }
}
