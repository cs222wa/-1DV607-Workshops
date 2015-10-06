using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.view
{
    class MemberConsole
    {
        private model.Member m;

        /*
        public Console()
        {
            m = new model.Member();
        }
         */
   
        public void DeleteMember()
        {
            System.Console.WriteLine("Are you sure you want to delete member? (y/n)");
        }
        public void EditName()
        {
            System.Console.WriteLine("Name: "); 
        }
        public void EditPN()
        {
            System.Console.WriteLine("Personal identity number: ");
        }
        public void IfEditName()
        {
            System.Console.WriteLine("Change name? (y/n)");
        }

        public void IfEditPN()
        {
            System.Console.WriteLine("Change personal identity number? (y/n)");
        }

        public void ListMembers(List<model.Member> memberRegister, List<model.Boat> boatRegister, int listType)
        {
            if (listType == 1)
            {
                System.Console.WriteLine("COMPACT LIST");
                System.Console.WriteLine("------------------------");
                foreach (var member in memberRegister)
                {
                    System.Console.WriteLine("Member id: " + member.Id);
                    System.Console.WriteLine("Name: " + member.Name);
                    System.Console.WriteLine("Number of boats: " + boatRegister.Count);
                    System.Console.WriteLine("------------------------");
                }
            }
            else if (listType == 2)
            {
                System.Console.WriteLine("VERBOSE LIST");
                System.Console.WriteLine("------------------------");
                foreach (var member in memberRegister)
                {
                    System.Console.WriteLine("Member id: " + member.Id);
                    System.Console.WriteLine("Name: " + member.Name);
                    System.Console.WriteLine("Personal identity number: " + member.PersonalIdentityNumber);
                    System.Console.WriteLine("Number of boats: " + member.BoatRegister.Count);
                    System.Console.WriteLine("------------------------");
                    // }
                    if (member.BoatRegister.Count > 0)
                    {
                        foreach (var boat in member.BoatRegister)
                        {
                            System.Console.WriteLine("Boats length: " + boat.Length);
                            System.Console.WriteLine("Boattype: " + boat.BoatType);
                        }
                    }
                }
            }
            else
            {
                //fixa något
            }
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
        public void ViewSpecificMember(model.Member member)
        {
            System.Console.WriteLine("VIEW MEMBER");
            System.Console.WriteLine("-------------------------");
            System.Console.WriteLine(member.Id);
            System.Console.WriteLine(member.Name);
            System.Console.WriteLine(member.PersonalIdentityNumber);
            System.Console.WriteLine("-------------------------");
        }
    }
}

