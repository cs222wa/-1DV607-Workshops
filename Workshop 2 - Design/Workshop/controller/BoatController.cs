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
        //model.Member m;
        model.MemberRegister mr;
        string boatType;
        float length;

        public BoatController()
        {
            v = new view.Console();
            bv = new view.BoatConsole();
            //m = new model.Member();
            mr = new model.MemberRegister();
            boatType = null;
            length = 0;
        }

        
        public void RegisterBoat()
        {
            int choosenMemberId = v.AskForMember("register boat for");
            bv.RegisterBoatLength();
            double length = double.Parse(Console.ReadLine());
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

            mr.RegisterBoat(choosenMemberId, length, boatType);
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
