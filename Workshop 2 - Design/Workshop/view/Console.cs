using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.view
{
    class Console
    {
        private model.Member m;

        public Console()
        {
            m = new model.Member();
        }

        public void ViewMenu() 
        {
            System.Console.WriteLine("MENU:");
            System.Console.WriteLine("1. Register new member");
            System.Console.WriteLine("2. List all members");
            System.Console.WriteLine("3. View specific member");
            System.Console.WriteLine("4. Edit member");
            System.Console.WriteLine("5. Delete member");
            System.Console.WriteLine("6. Register boat");
            System.Console.WriteLine("7. Edit boat");
            System.Console.WriteLine("8. Delete boat");
            System.Console.WriteLine("9. Exit");            
        }

        public void Continue()
        {
            System.Console.WriteLine("Press any key to continue.");
            System.Console.ReadKey();
        }

         public void ConfirmMessage(string prompt)
         {
             System.Console.WriteLine(prompt);
         }

         public void ViewErrorMessage(string prompt)         
         {
             System.Console.WriteLine(prompt);
             System.Console.ReadKey();
         }

        public void RegisterName()
         {
             System.Console.Clear();
             System.Console.WriteLine("REGISTER MEMBER");
             System.Console.WriteLine("Name: ");
         }

        public void RegisterPersonalIdentityNumber()
        {
            System.Console.WriteLine("Personal identity number: ");            
        }

        public void ChooseListType()
        {
            System.Console.WriteLine("Choose type of list:");
            System.Console.WriteLine("1. Compact list");
            System.Console.WriteLine("2. Verbose list");
        }



        public void ListMembers(List<model.Member> memberRegister, int listType)            
        {
            if (listType == 1)
            {
                foreach (var member in memberRegister)
                {
                    System.Console.WriteLine(member.Id + "\t" + member.Name);
                }
            }
            else if (listType == 2)
                {
                foreach (var member in memberRegister)
                {
                    System.Console.WriteLine(member.Id + "\t" + member.Name);
                }
            }
            else
            {
                //fixa något
            }
        }


        public int AskForMember(string prompt)
        {
            System.Console.WriteLine("Choose member to " + prompt + " (memberID): ");
            return int.Parse(System.Console.ReadLine());
        }

        public void ViewSpecificMember(model.Member member)
        {
            System.Console.WriteLine("VIEW MEMBER");
            System.Console.WriteLine("-------------------------");
            System.Console.WriteLine(member.Id);
            System.Console.WriteLine(member.Name);
            System.Console.WriteLine(member.PersonalIdentityNumber);
            System.Console.WriteLine("-------------------------");
        }

        public void EditMember()
        {
            System.Console.WriteLine("test Edit");
        }

        public void DeleteMember()
        {
            System.Console.WriteLine("Are you sure you want to delete member? (y/n)");
        }
        
    }
}
