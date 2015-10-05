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

            mr.RegisterBoat(memberRegister, choosenMemberId, length, boatType);
            v.Continue();
        }

        public void EditBoat()
        {

        }

        public void DeleteBoat()
        {

        }
    }
}
