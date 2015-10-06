using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.model
{
    class MemberEditor : RegisterEditor
    {

        
        public void DeleteMember(int choosenMemberId)
        {
            foreach (var member in memberRegister)
            {
                if (member.Id == choosenMemberId)
                {
                    DeleteMember(member);
                    break;
                }
            }
            UpdateTextFile();
        }

        public void EditMemberName(int choosenMemberId, string name)
        {
            foreach (var member in memberRegister)
            {
                if (member.Id == choosenMemberId)
                {
                    member.Name = name;
                    break;
                }
            }
            UpdateTextFile();
        }

        public void EditMemberPN(int choosenMemberId, string pn)
        {
            foreach (var member in memberRegister)
            {
                if (member.Id == choosenMemberId)
                {
                    member.PersonalIdentityNumber = pn;
                    break;
                }
            }
            UpdateTextFile();
        }

        public List<Member> getListMembers()
        {
            return memberRegister;
        }

        public Member GetMember(int choosenMemberId)
        {
            foreach (var member in memberRegister)
            {
                if (member.Id == choosenMemberId)
                {
                    return member;
                }

            }
            return null;
        }

        public void RegisterMember(string name, string personalIdentityNumber)
        {
            List<Boat> boatList = new List<Boat>();             //flytta
            int id = (GetLastMemberId()) + 1;
            model.Member newMember = new model.Member(id, name, personalIdentityNumber, boatList);
            AddMember(newMember);
            UpdateTextFile();
        }
        public bool CheckIfMemberExists(int choosenMemberId)
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
