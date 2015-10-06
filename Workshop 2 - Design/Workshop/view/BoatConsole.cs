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
        public void IfEditBoatLength()
        {
            System.Console.WriteLine("Change boat length? (y/n)");
        }

        public void EditBoatLength()
        {
            System.Console.WriteLine("New boat length: ");
        }

        public void IfEditBoatType()
        {
            System.Console.WriteLine("Change boattype? (y/n)");
        }

        public void EditBoatType()
        {
            System.Console.WriteLine("New boattype: ");
        }

        public void DeleteBoat()
        {
            System.Console.WriteLine("Are you sure you want to delete boat? (y/n)");
        }
    }
}
