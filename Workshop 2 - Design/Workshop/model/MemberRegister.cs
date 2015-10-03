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

       public void DeleteMember(int choosenMemberId, List<Member> memberRegister)
        {
            re.ClearTextFile();
            foreach (var member in memberRegister)
            {
                if (member.Id == choosenMemberId)
                {
                    model.Member memberToRemove = new model.Member();
                    re.DeleteMember(memberToRemove);
                }
                else
                {                    
                    re.UpdateTextFile(member);
                }                
            }            
       }

       // public List<Member> UpdateList()
       //{
       //    List<model.Member> memberRegister = re.ListMembers();
       //    return memberRegister;
       //}   


        
    }
}
