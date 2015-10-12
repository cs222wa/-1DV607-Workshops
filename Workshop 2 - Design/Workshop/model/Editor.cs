using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Workshop.model
{
    class Editor
    {
               
        protected List<Member> memberRegister;

        public Editor()
        {
            memberRegister = new List<Member>();
            ReadTextFile();
        }

        private void ReadTextFile()
        {
            using (StreamReader reader = new StreamReader("memberregister.txt"))
            {
                while (!reader.EndOfStream)
                {
                    List<Boat> boatList = new List<Boat>();
                    string line = reader.ReadLine();
                    string name = reader.ReadLine();
                    string personalIdentityNumber = reader.ReadLine();
                    int numberOfBoats = int.Parse(reader.ReadLine());
                    for (int i = 0; i < numberOfBoats; i++)
                    {
                        string boatType = reader.ReadLine();
                        float length = float.Parse(reader.ReadLine());
                        boatList.Add(new Boat(length, boatType));
                    }
                    int id = int.Parse(reader.ReadLine());
                    memberRegister.Add(new Member(id, name, personalIdentityNumber, boatList));
                }
                reader.Close();
            }
        }

        protected void UpdateTextFile()
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

        protected int GetLastMemberId()
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

        protected void AddMember(model.Member memberToAdd)
        {
            memberRegister.Add(memberToAdd);
        }

        protected void DeleteMember(model.Member memberToRemove)
        {
            memberRegister.Remove(memberToRemove);
        }
    }
}
