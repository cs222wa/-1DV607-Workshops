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
            List<Boat> boatList = new List<Boat>();             //flytta
            int id = (re.GetLastMemberId()) + 1;
            model.Member newMember = new model.Member(id, name, personalIdentityNumber, boatList);
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
       public void RegisterBoat(int memberId, float length, string boatType, List<model.Member> memberRegister)
       {
           foreach (var member in memberRegister)
           {
               if (member.Id == memberId)
               {
                   member.BoatRegister = m.RegisterBoat(length, boatType);
                   break;
               }
           }
           re.UpdateTextFile();
       }

        public void EditBoatLength(int choosenMemberId)
       {
           foreach (var member in memberRegister)
           {
               if (member.Id == choosenMemberId)
               {
                   //fixa
                   break;
               }
           }
           re.UpdateTextFile();
       }

        public void EditBoatType(int choosenMemberId)
        {
            foreach (var member in memberRegister)
            {
                if (member.Id == choosenMemberId)
                {
                    //fixa
                    break;
                }
            }
            re.UpdateTextFile();
        }

        //public void DeleteBoat(int choosenMemberId, List<Member> memberRegister)
        //{
            
        //    foreach (var member in memberRegister)
        //    {
        //        if (member.Id == choosenMemberId)
        //        {
        //            //re.DeleteMember(member);
        //            break;
        //        }
        //    }
        //    re.UpdateTextFile();
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
