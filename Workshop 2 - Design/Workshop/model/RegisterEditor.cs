using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Workshop.model
{
    class RegisterEditor
    {
        private List<Member> memberRegister;
  
        public RegisterEditor()
        {
            memberRegister = new List<Member>();
        }

        public void UpdateTextFile(model.Member member)
        {
            using (StreamWriter writer = new StreamWriter ("memberRegister.txt", true))      
            {                
                writer.WriteLine("--------------------");
                writer.WriteLine(member.Name);
                writer.WriteLine(member.PersonalIdentityNumber);
                writer.WriteLine(member.Id);                
                writer.Close();
            }
        }

        public int GetLastMemberId()
        {
            using (StreamReader reader = new StreamReader("memberRegister.txt"))
            {
                string lastLine = File.ReadLines("memberRegister.txt").Last();                
                return int.Parse(lastLine);
            }
        }
                
        public List<Member> ListMembers()
        {
            using (StreamReader reader = new StreamReader("memberregister.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string name = reader.ReadLine();
                    string personalIdentityNumber = reader.ReadLine();
                    int id = int.Parse(reader.ReadLine());                   
                    memberRegister.Add(new Member(id, name, personalIdentityNumber));                    
                }
                reader.Close();
            }
            return memberRegister;
        }
    }
}
