using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.model
{
    class Menu
    {
        view.Console m_view;

        public Menu(view.Console a_view)
        {
            m_view = a_view;
        }

        public void ChooseFromMenu(model.Member a_member, model.Menu a_menu)
        {
            m_view.Start();
            while (m_view.Continue())               //FUNKAR EJ EFTER FÖRSTA GÅNGEN
            {
                switch (m_view.ViewMenu())
                {
                    case 1: a_member.RegisterMember(a_member, m_view, a_menu);
                        break;
                    case 2: a_member.ListMember(m_view);
                        break;
                    case 3: a_member.ViewMember(m_view);
                        break;
                    case 4: a_member.EditMember(m_view);
                        break;
                    

                }
            }
           
                
            
            
        }
    }
}
