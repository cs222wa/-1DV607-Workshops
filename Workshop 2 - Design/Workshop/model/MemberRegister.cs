using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Workshop.model
{
    class MemberRegister
    {
        private List<string> memberRegister;
        private StreamReader reader;
        
        public MemberRegister()
        {
            memberRegister = new List<string>();
            reader = new StreamReader("memberRegister.txt");
        }

        public int GetMemberId(int id)
        {
            using (reader)
            {
                string lastLine = File.ReadLines("memberRegister.txt").Last();
                string firstChar = lastLine.Substring(0,2);
                id = int.Parse(firstChar);
                id++;
                return id;
            }
        }

        public void UpdateTextFile(int id, string name, string personalIdentityNumber)
        {
            using (StreamWriter writer = new StreamWriter("memberRegister.txt", true))
            {
                writer.WriteLine(id + "\t" + name + "\t" + personalIdentityNumber);
                writer.Close();                
            }
        }

        
        public void ListMembersCompact()                            //name, memberID, number of boats
        {
            Console.WriteLine("Test Compact");                      //ta bort
            using (reader)                                                                          
            {                                                        //Antal båtar läggas till i CompactList
                string line = null;                                                         
                while ((line = reader.ReadLine()) != null)
                {
                    memberRegister.Add(line);                       //Skicka tillbaka alla rader
                    //view.Console v = new view.Console();          //Detta funkar, men så får man ju inte göra :p Ska skickas tillbaka till Member, sen ska v.ListAllMembers(line); anropas
                    //v.ListAllMembers(line);                       
                }               
            }          
        }

        public void ListMembersVerbose()                            //name, personal number, member id and boats with boat information
        {
            Console.WriteLine("test verbose");                      //ta bort
        }

        public string GetSpecifikMember(int choosenMemberId)
        {
            string choosenMember = memberRegister[choosenMemberId - 1];
            return choosenMember;
        }

        public void DeleteMember(int id)
        {
            string choosenMember = memberRegister[0];                           //funkar ej
            using (reader)
            {                                                                               
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    memberRegister.Add(line);
                    if (line == choosenMember)                                  //??
                    {
                        Console.WriteLine("ta bort: " + line);
                    }
                }
            }
            
        }
    }
}
