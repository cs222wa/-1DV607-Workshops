using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.model
{
    class MemberRegister
    {
      // private List<string> memberRegister;
       model.RegisterEditor re;
        
               
        public MemberRegister()
        {
            //memberRegister = new List<string>();
            re = new model.RegisterEditor();
            
        }

        public void RegisterMember(string name, string personalIdentityNumber)
        {
            int id = (re.GetLastMemberId()) + 1;
            model.Member newMember = new model.Member(id, name, personalIdentityNumber);           
            re.UpdateTextFile(newMember);
        }

       

        //public int GetMemberId(int id)       
        //{
        //    using (reader)
        //    {
        //        string lastLine = File.ReadLines("memberRegister.txt").Last();
        //        string firstChar = lastLine.Substring(0,2);
        //        id = int.Parse(firstChar);
        //        id++;
        //        return id;
        //    }
        //}

        //public void UpdateTextFile(int id, string name, string personalIdentityNumber)
        //{
        //    using (StreamWriter writer = new StreamWriter("memberRegister.txt", true))
        //    {
        //        writer.WriteLine(id + "\t" + name + "\t" + personalIdentityNumber);
        //        writer.Close();                
        //    }
        //}

        public List<Member> ListMembersCompact()
        {
            Console.WriteLine("test compact");
            List<Member> memberRegister = re.ListMembers();            
            return memberRegister;           
        }
       
        //public void ListMembersCompact()                            //name, memberID, number of boats
        //{
        //    Console.WriteLine("Test Compact");                      //ta bort
        //    using (reader)                                                                          
        //    {                                                        //Antal båtar läggas till i CompactList
        //        string line = null;                                                         
        //        while ((line = reader.ReadLine()) != null)
        //        {
        //            memberRegister.Add(line);                       //Skicka tillbaka alla rader
        //            //view.Console v = new view.Console();          //Detta funkar, men så får man ju inte göra :p Ska skickas tillbaka till Member, sen ska v.ListAllMembers(line); anropas
        //            //v.ListAllMembers(line);                          
        //        }               
        //    }          
        //}

       

        //public string GetSpecifikMember(int choosenMemberId)
        //{
        //    string choosenMember = memberRegister[choosenMemberId - 1];
        //    return choosenMember;
        //}

        //public string HandleMember(string id)
        //{
        //    int choosenMemberId = int.Parse(id);
        //    return GetSpecifikMember(choosenMemberId);
        //}

        //public void DeleteMember(string choosenMember)
        //{
        //    using (reader)
        //    {                                                                               
        //        string line = null;
        //        while ((line = reader.ReadLine()) != null)
        //        {
        //            memberRegister.Add(line);
        //            if (line == choosenMember)                                  //??
        //            {
        //                Console.WriteLine("ta bort: " + line);
        //            }
        //        }
        //    }
            
        //}
    }
}
