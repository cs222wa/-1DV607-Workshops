using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.model
{
    class MemberRegister
    {
       model.RegisterEditor re;
        
               
        public MemberRegister()
        {
            re = new model.RegisterEditor();            
        }

        public void RegisterMember(string name, string personalIdentityNumber)
        {
            int id = (re.GetLastMemberId()) + 1;
            model.Member newMember = new model.Member(id, name, personalIdentityNumber);           
            re.UpdateTextFile(newMember);
        }
             

        public List<Member> ListMembers()
        {
            List<Member> memberRegister = re.ListMembers();            
            return memberRegister;           
        }



        public List<Member> GetSpecifikMember(int choosenMemberId)
        {
            List<model.Member> memberRegister = re.ListMembers();
            return memberRegister;
            
            //string choosenMember = memberRegister[choosenMemberId - 1];
            //return choosenMember;
        }

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
