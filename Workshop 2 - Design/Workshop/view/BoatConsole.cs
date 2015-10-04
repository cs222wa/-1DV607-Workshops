using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.view
{
    class BoatConsole
    {
        public void RegisterBoatLength()
        {
            System.Console.WriteLine("Boat's length: ");
        }

        public void RegisterBoatType()
        {
            System.Console.WriteLine("Choose boattype: ");
            System.Console.WriteLine("1. Sailboat");
            System.Console.WriteLine("2. Motorsailor");
            System.Console.WriteLine("3. Kayak/canoe");
            System.Console.WriteLine("4. Other");
        }
    }
}
