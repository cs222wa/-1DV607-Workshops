using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.controller
{
    class Controller
    {
        view.Console v; //general console

        public Controller()
        {
            v = new view.Console();
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
                    case 1: RegisterMember();
                        break;
                    case 2: ListMembers();
                        break;
                    case 3: ViewMember();
                        break;
                    case 4: EditMember();
                        break;
                    case 5: DeleteMember();
                        break;
                    case 6: bc.RegisterBoat(memberRegister);
                        break;
                    case 7: bc.EditBoat(memberRegister);
                        break;
                    case 8: bc.DeleteBoat(memberRegister);
                        break;
                    case 9: return;
                    default:
                        break;
                }
            }
        }

        /*
        view.Console v; //general console
        model.MemberRegister mr;
        model.Member m;
        controller.BoatController bc;
        List<model.Member> memberRegister;
        List<model.Boat> boatRegister;
       
        public Controller()
        {
            v = new view.Console();
            mr = new model.MemberRegister();
            m = new model.Member();
            bc = new controller.BoatController();
            boatRegister = new List<model.Boat>();
        }

        public void Start()
        {
            memberRegister = mr.ListMembers(m);
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
                    case 1: RegisterMember();
                        break;
                    case 2: ListMembers();
                        break;
                    case 3: ViewMember();
                        break;
                    case 4: EditMember();           
                        break;
                    case 5: DeleteMember();
                        break;                    
                    case 6: bc.RegisterBoat(memberRegister);
                        break;
                    case 7: bc.EditBoat(memberRegister);
                        break;
                    case 8: bc.DeleteBoat(memberRegister);
                        break;
                    case 9: return;
                    default:
                        break;
                }
            }
        }
         * */
    }
}
