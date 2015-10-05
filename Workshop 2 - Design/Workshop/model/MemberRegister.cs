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
       model.Member m;
       List<model.Member> memberRegister;                   
               
        public MemberRegister()
        {
            re = new model.RegisterEditor();
            m = new model.Member();
            memberRegister = new List<model.Member>();
        }
        
        public void RegisterMember(string name, string personalIdentityNumber)
        {
            int id = (re.GetLastMemberId()) + 1;
            model.Member newMember = new model.Member(id, name, personalIdentityNumber);
            re.AddMember(newMember);
            re.UpdateTextFile();
            //re.SaveTextFile(newMember);
        }

        public List<Member> ListMembers(model.Member member)
        {
            List<Member> memberRegister = re.ListMembers(member);
            return memberRegister;
        }

       public void DeleteMember(int choosenMemberId, List<Member> memberRegister)
        {
            foreach (var member in memberRegister)
            {
                if (member.Id == choosenMemberId)
                {
                    re.DeleteMember(member);
                    break;
                }
             }
            re.UpdateTextFile();
       }

        public void EditMemberName(int choosenMemberId, string name, List<Member> memberRegister)
       {
           foreach (var member in memberRegister)
           {
               if (member.Id == choosenMemberId)
               {
                   member.Name = name;
                   break;
               }
           }
           re.UpdateTextFile();
       }

        public void EditMemberPN(int choosenMemberId, string pn, List<Member> memberRegister)
        {
            foreach (var member in memberRegister)
            {
                if (member.Id == choosenMemberId)
                {
                    member.PersonalIdentityNumber = pn;
                    break;
                }
            }
            re.UpdateTextFile();
        }
       public void RegisterBoat(List<model.Member> memberRegister, int memberId, float length, string boatType)
       {
           m.RegisterBoat(memberId, length, boatType);
           foreach (var member in memberRegister)
           {
               if (memberId == member.Id)
               {
                   //re.UpdateTextFile(member);
               }
           }           
       }

       // public List<Member> UpdateList()
       //{
       //    List<model.Member> memberRegister = re.ListMembers();
       //    return memberRegister;
       //}
   
        public bool CheckIfMemberExists(int choosenMemberId, List<Member> memberRegister)
       {
           foreach (var member in memberRegister)
           {
               if (choosenMemberId == member.Id)
               {
                   return true;
               }
           }
           return false;
       }
    }
}
