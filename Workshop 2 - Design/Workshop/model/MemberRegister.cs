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

        public void ListMembers()
        {
            using (reader)                                                                          //Hur visas VerboseList?
            {                                                                               //Antal båtar läggas till i CompactList
                string line = null;                                                         
                while ((line = reader.ReadLine()) != null)
                {
                    memberRegister.Add(line);
                    Console.WriteLine("line" + line);                                       //Skicka tillbaka alla rader                    
                }                
            }
        }

        public string GetSpecifikMember(int choosenMemberId)
        {
            string choosenMember = memberRegister[choosenMemberId - 1];
            return choosenMember;
        }
    }
}
