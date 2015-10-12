using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.model
{
    class BoatEditor : Editor
    {

        public List<Boat> GetBoats(int choosenMemberId)
        {
            foreach (var member in memberRegister)
            {
                if (member.Id == choosenMemberId)
                {
                    return member.BoatRegister;
                }                
            }
            return null;            
        }

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

        public void EditBoatLength(int choosenMemberId, int boatNr, float length)
        {
            foreach (var member in memberRegister)
            {
                if (member.Id == choosenMemberId)
                {
                    Boat boatToEdit = member.BoatRegister[boatNr - 1];
                    boatToEdit.Length = length;
                    break;
                }
            }
            UpdateTextFile();
        }

        public void EditBoatType(int choosenMemberId, int boatNr, string type)
        {
            foreach (var member in memberRegister)
            {
                if (member.Id == choosenMemberId)
                {
                    Boat boatToEdit = member.BoatRegister[boatNr - 1];
                    boatToEdit.BoatType = type;
                    break;
                }
            }
            UpdateTextFile();
        }

        public void DeleteBoat(int choosenMemberId, int boatNr)
        {
            foreach (var member in memberRegister)
            {
                if (member.Id == choosenMemberId)
                {
                    Boat boatToRemove = member.BoatRegister[boatNr - 1];
                    member.BoatRegister.Remove(boatToRemove);
                    break;
                }
            }
            UpdateTextFile();
        }

        public bool CheckIfBoatExists(int choosenMemberId, int boatNr, List<Boat> boatRegister)
        {
            foreach (var member in memberRegister)
            {
                if (choosenMemberId == member.Id)
                {
                    for (int i = 0; i < boatRegister.Count; i++)
                    {
                        if (boatNr == i + 1)
                        {
                            return true;
                        }
                    }                    
                }
            }
            return false;
        }
    }
}
