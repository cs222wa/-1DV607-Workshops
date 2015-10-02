using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.model
{
    class Menu
    {
        view.Console v;
        public Menu()
        {
            v = new view.Console();
        }

        public void ChooseFromMenu(model.Member m, model.Boat b)
        {            
            while (true)
            {
                Console.Clear();
                v.ViewMenu();
                int value = int.Parse(Console.ReadLine());
                switch (value)
                {
                    case 1: m.RegisterMember();
                        break;
                    case 2: m.ListMember();
                        break;
                    case 3: m.ViewMember();
                        break;
                    case 4: m.EditMember();
                        break;
                    case 5: m.DeleteMember();
                        break;
                    case 6: b.RegisterBoat();
                        break;
                    case 9: return;                        
                }
            }
        }
    }
}
