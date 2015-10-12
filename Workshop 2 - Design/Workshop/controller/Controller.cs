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
         
        public Controller()
        {
            v = new view.Console();
            me = new model.MemberEditor(); 
        }

        public void ChooseFromMenu()
        {
            while (true)
            {
                Console.Clear();
                int value = v.ViewMenu();
                switch (value)
                {
                    case 1:
                        {
                            MemberController mc = new MemberController();
                            mc.RegisterMember();
                            break;
                        }
                    case 2:
                        {
                            MemberController mc = new MemberController();
                            mc.ListMembers();
                            break;
                        }
                    case 3:
                        {
                            MemberController mc = new MemberController();
                            mc.ViewMember();
                            break;
                        }
                    case 4:
                        {
                            MemberController mc = new MemberController();
                            mc.EditMember();
                            break;
                        }
                    case 5:
                        {
                            MemberController mc = new MemberController();
                            mc.DeleteMember();
                            break;
                        }
                    case 6:
                        {
                            BoatController bc = new BoatController();
                            bc.RegisterBoat();
                            break;
                        }
                    case 7:
                        {
                            BoatController bc = new BoatController();
                            bc.EditBoat();
                            break;
                        }
                    case 8:
                        {
                            BoatController bc = new BoatController();
                            bc.DeleteBoat();
                            break;
                        }
                    case 9: return;
                    default:
                        break;
                }
            }
        }
    }
}
