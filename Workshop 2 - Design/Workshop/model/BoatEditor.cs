using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.model
{
    class BoatEditor : RegisterEditor
    {
        public void RegisterBoat(int memberId, string type, float length)
        {
            foreach (var member in memberRegister)
            {
                if (member.Id == memberId)
                {
                    member.BoatRegister = member.RegisterBoat(length, type);
                    break;
                }
            }
            UpdateTextFile();
        }

        public void EditBoatLength(int choosenMemberId, double length)
        {
            foreach (var member in memberRegister)
            {
                if (member.Id == choosenMemberId)
                {
                    //Boat.Length = length;         HUR?!
                    break;
                }
            }
            UpdateTextFile();
        }

        public void EditBoatType(int choosenMemberId, string type)
        {
            foreach (var member in memberRegister)
            {
                if (member.Id == choosenMemberId)
                {
                    //boat.Type = type      HUR??
                    break;
                }
            }
            UpdateTextFile();
        }

        public void DeleteBoat(int choosenMemberId)
        {
            
        }
    }
}
