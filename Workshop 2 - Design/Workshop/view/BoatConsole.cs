using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.view
{
    class BoatConsole
    {
        public float RegisterBoatLength()
        {
            System.Console.WriteLine("Boat's length: ");
            return float.Parse(System.Console.ReadLine());
        }
        public string RegisterBoatType()
        {
            System.Console.WriteLine("Choose boattype: ");
            System.Console.WriteLine("1. Sailboat");
            System.Console.WriteLine("2. Motorsailor");
            System.Console.WriteLine("3. Kayak/canoe");
            System.Console.WriteLine("4. Other");
            return System.Console.ReadLine();
        }

        public void DisplayBoats(List<model.Boat> boatRegister)
        {
            System.Console.WriteLine("-------------------------");
            for (int i = 0; i < boatRegister.Count; i++)
            {
                System.Console.WriteLine("{0} {1}", i + 1, boatRegister[i].BoatType + ", " + boatRegister[i].Length);
            }
            System.Console.WriteLine("-------------------------");
        }

        public string IfEditBoatLength()
        {
            System.Console.WriteLine("Change boat length? (y/n)");
            return System.Console.ReadLine();
        }

        public float EditBoatLength()
        {
            System.Console.WriteLine("New boat length: ");
            return float.Parse(System.Console.ReadLine());
        }

        public string IfEditBoatType()
        {
            System.Console.WriteLine("Change boattype? (y/n)");
            return System.Console.ReadLine();
        }

        public string DeleteBoat()
        {
            System.Console.WriteLine("Are you sure you want to delete boat? (y/n)");
            return System.Console.ReadLine();
        }

        public int AskForBoat(string prompt)                  
        {
            System.Console.WriteLine("Choose what boat you want to " + prompt);
            return int.Parse(System.Console.ReadLine());
        }
    }
}
