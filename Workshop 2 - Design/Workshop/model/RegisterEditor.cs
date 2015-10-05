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

        //public void SaveTextFile(model.Member member)
        //{
        //    using (StreamWriter writer = new StreamWriter ("memberRegister.txt", true))      
        //    {
        //            writer.WriteLine("--------------------");

        //            writer.WriteLine(member.Name);
        //            writer.WriteLine(member.PersonalIdentityNumber);
        //            writer.WriteLine(member.BoatRegister.Count());
        //            if (member.BoatRegister.Count() > 0)
        //            {
        //                foreach (model.Boat boat in member.BoatRegister)
        //                {
        //                    writer.WriteLine(boat.BoatType);
        //                    writer.WriteLine(boat.Length);
        //                }
        //            }
        //            writer.WriteLine(member.Id);
        //        writer.Close();
        //    }
        //}

        public void UpdateTextFile()
        {
            using (StreamWriter writer = new StreamWriter("memberRegister.txt", false))
            {
                foreach (var member in memberRegister)
                {
                    writer.WriteLine("--------------------");

                    writer.WriteLine(member.Name);
                    writer.WriteLine(member.PersonalIdentityNumber);
                    writer.WriteLine(member.BoatRegister.Count());
                    if (member.BoatRegister.Count() > 0)
                    {
                        foreach (model.Boat boat in member.BoatRegister)
                        {
                            writer.WriteLine(boat.BoatType);
                            writer.WriteLine(boat.Length);
                        }
                    }
                    writer.WriteLine(member.Id);
                    }                
                writer.Close();
            }
        }

        //public void ClearTextFile()
        //{
        //    using (var stream = new FileStream("memberRegister.txt", FileMode.Truncate))
        //    {

        //    }
        //}
        
        public int GetLastMemberId()
        {            
            using (StreamReader reader = new StreamReader("memberRegister.txt"))
            {
                if (new FileInfo("memberRegister.txt").Length == 0)
                {
                    return 0;
                }
                string lastLine = File.ReadLines("memberRegister.txt").Last();                
                return int.Parse(lastLine);
            }
        }

        public List<Member> ListMembers(model.Member member)
        {
            List<Boat> boatList = new List<Boat>();
            using (StreamReader reader = new StreamReader("memberregister.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string name = reader.ReadLine();
                    string personalIdentityNumber = reader.ReadLine();
                    int numberOfBoats = int.Parse(reader.ReadLine());
                    if (member.BoatRegister.Count() > 0)
                    {
                        foreach (model.Boat boat in member.BoatRegister)
                        {
                            string boatType = reader.ReadLine();
                            string length = reader.ReadLine();
                        }
                    }
                    int id = int.Parse(reader.ReadLine());
                    memberRegister.Add(new Member(id, name, personalIdentityNumber, boatList));
                }
                reader.Close();
            }
            return memberRegister;
        }

        public void DeleteMember(model.Member memberToRemove)
        {
            memberRegister.Remove(memberToRemove);
        }

        public void AddMember(model.Member memberToAdd)
        {
            memberRegister.Add(memberToAdd);
        }
    }
}
