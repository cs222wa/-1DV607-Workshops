using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.controller
{
    class Controller
    {
        view.Console v; 
        model.MemberEditor me;
        controller.BoatController bc;
        controller.MemberController mc;
        List<model.Member> memberRegister;
 

        public Controller()
        {
            v = new view.Console();
            me = new model.MemberEditor();
            bc = new controller.BoatController();
            mc = new controller.MemberController();
 
        }

        public void Start()
        {
            memberRegister = me.getListMembers();
            ChooseFromMenu();
        }

        public void ChooseFromMenu()
        {
            while (true)
            {
                Console.Clear();
                v.ViewMenu();
                int value = int.Parse(Console.ReadLine());
                switch (value)
                {
                    case 1: mc.RegisterMember();
                        break;
                    case 2: mc.ListMembers();
                        break;
                    case 3: mc.ViewMember();
                        break;
                    case 4: mc.EditMember();
                        break;
                    case 5: mc.DeleteMember();
                        break;
                    case 6: bc.RegisterBoat();
                        break;
                    case 7: bc.EditBoat();
                        break;
                    case 8: bc.DeleteBoat();
                        break;
                    case 9: return;
                    default:
                        break;
                }
            }
        }
    }
}
