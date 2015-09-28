using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.view
{
    class Console
    {
        public void Start()
        {
            System.Console.WriteLine("Press any key to view menu, q to quit.");
        }

        public bool Continue()
        {
            return System.Console.ReadKey().KeyChar != 'q';
        }
       
         public int ViewMenu()           
        {
            System.Console.Clear();
            System.Console.WriteLine("MENU:");
            System.Console.WriteLine("1. Register new member");
            System.Console.WriteLine("2. List all members");
            System.Console.WriteLine("3. View specifik member");
            System.Console.WriteLine("4. Edit member");
            System.Console.WriteLine("5. Delete member");
            System.Console.WriteLine("6. Register boat");
            System.Console.WriteLine("7. Edit boat");
            System.Console.WriteLine("8. Delete boat");
            
            return int.Parse(System.Console.ReadLine());
        }

         public void ConfirmChange(string prompt)
         {
             System.Console.WriteLine(prompt);
         }
         
        public string RegisterName()
         {
             System.Console.Clear();
             System.Console.WriteLine("REGISTER MEMBER");
             System.Console.WriteLine("Name: ");
             return System.Console.ReadLine();
         }

        public int RegisterPersonalIdentityNumber()
        {
            System.Console.WriteLine("Personal identity number: ");
            return int.Parse(System.Console.ReadLine());
        }

        public int ChooseListType()
        {
            System.Console.WriteLine("Choose type of list:");
            System.Console.WriteLine("1. Compact list");
            System.Console.WriteLine("2. Verbose list");
            return int.Parse(System.Console.ReadLine());
        }

        public void ListAllMembers(string line)
        {
            System.Console.WriteLine(line);            
        }

        public int AskForMemberToView()
        {
            System.Console.WriteLine("Choose member to view (memberID): ");
            return int.Parse(System.Console.ReadLine());
        }

        public void ViewSpecifikMember(string member)
        {
            System.Console.WriteLine(member);
        }

        public void AskForMemberToEdit()
        {
            System.Console.WriteLine("Test editmember");
        }
    }
}
