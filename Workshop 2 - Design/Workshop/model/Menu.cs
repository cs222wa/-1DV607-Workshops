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

        public void ChooseFromMenu(model.Member m)
        {
            v.ViewMenu();
            int value = int.Parse(Console.ReadLine());
            switch (value)
            {
                case 1: m.RegisterMember(v);
                    break;
                case 2: m.ListMember(v);
                    break;
                case 3: m.ViewMember(v);
                    break;
                case 4: m.EditMember(v);
                    break;
            }
        }
    }
}
