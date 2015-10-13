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
                 
        public Controller()
        {
            v = new view.Console();
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
                            MemberController mc = new MemberController();  
                            int choosenMemberId = mc.HandleMemberForBoatHandling("register boat for");
                            if (choosenMemberId == 0)
                            {
                                v.Continue();
                                break;
                            }
                            BoatController bc = new BoatController();
                            bc.RegisterBoat(choosenMemberId);
                            break;
                        }
                    case 7:
                        {
                            MemberController mc = new MemberController();
                            int choosenMemberId = mc.HandleMemberForBoatHandling("edit boat for");
                            if (choosenMemberId == 0)
                            {
                                v.Continue();
                                break;
                            }
                            BoatController bc = new BoatController();
                            bc.EditBoat(choosenMemberId);
                            break;
                        }
                    case 8:
                        {
                            MemberController mc = new MemberController();
                            int choosenMemberId = mc.HandleMemberForBoatHandling("delete boat for");
                            if (choosenMemberId == 0)
                            {
                                v.Continue();
                                break;
                            }
                            BoatController bc = new BoatController();
                            bc.DeleteBoat(choosenMemberId);
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
