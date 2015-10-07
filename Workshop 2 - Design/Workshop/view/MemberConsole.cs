using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.view
{
    class MemberConsole
    {
          
        public string DeleteMember()
        {
            System.Console.WriteLine("Are you sure you want to delete member? (y/n)");
            return System.Console.ReadLine();
        }
        public string EditName()
        {
            System.Console.WriteLine("Name: ");
            return System.Console.ReadLine();
        }
        public string EditPN()
        {
            System.Console.WriteLine("Personal identity number: ");
            return System.Console.ReadLine();
        }
        public string IfEditName()
        {
            System.Console.WriteLine("Change name? (y/n)");
            return System.Console.ReadLine();
        }

        public string IfEditPN()
        {
            System.Console.WriteLine("Change personal identity number? (y/n)");
            return System.Console.ReadLine();
        }

        public void ListMembers(List<model.Member> memberRegister, int listType)
        {
            if (listType == 1)
            {
                System.Console.WriteLine("COMPACT LIST");
                System.Console.WriteLine("------------------------");
                foreach (var member in memberRegister)
                {
                    System.Console.WriteLine("Member id: " + member.Id);
                    System.Console.WriteLine("Name: " + member.Name);
                    System.Console.WriteLine("Number of boats: " + member.BoatRegister.Count);
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
                    System.Console.WriteLine();
                    if (member.BoatRegister.Count > 0)
                    {
                        foreach (var boat in member.BoatRegister)
                        {
                            System.Console.WriteLine("Boats length: " + boat.Length);
                            System.Console.WriteLine("Boattype: " + boat.BoatType);
                            System.Console.WriteLine();
                        }
                     }
                    System.Console.WriteLine("------------------------");
                }
            }
            else
            {
                System.Console.WriteLine("You didn't choose list. Try again.");
            }
        }
        public string RegisterName()
        {
            System.Console.Clear();
            System.Console.WriteLine("REGISTER MEMBER");
            System.Console.WriteLine("Name: ");
            return System.Console.ReadLine();
        }
        public string RegisterPersonalIdentityNumber()
        {
            System.Console.WriteLine("Personal identity number: ");
            return System.Console.ReadLine();
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

        public void DisplayMembers(List<model.Member> memberRegister)
        {
            System.Console.WriteLine("-------------------------");
            foreach (var member in memberRegister)
            {                
                System.Console.WriteLine("{0} {1}", member.Id, member.Name);
            }
            System.Console.WriteLine("-------------------------");
        }
    }
}

