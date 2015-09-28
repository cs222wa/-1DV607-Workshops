using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            model.Member member = new model.Member();
            view.Console console = new view.Console();
            model.Menu menu = new model.Menu(console);            
             
            menu.ChooseFromMenu(member, menu);             
        }

            
    }
}
    
            
        
    

