using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Workshop.model
{
    class Member
    {
        private int id;
        private string name;
        private string personalIdentityNumber;
        public List<Boat> boatRegister = new List<Boat>();

        public Member()
        {

        }
        
        public Member(int id, string name, string personalIdentityNumber, List<Boat> boatList)
        {
            Id = id;
            Name = name;
            PersonalIdentityNumber = personalIdentityNumber;
            boatRegister = boatList;
        }
        

        public List<Boat> BoatRegister
        {
            get { return boatRegister; }
            set { boatRegister = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                {
                    if (String.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentNullException();
                    }                    
                    name = value;
                }
            }
        }
        public string PersonalIdentityNumber
        {
            get { return personalIdentityNumber; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException();
                }
                if (!Regex.IsMatch(value, @"^(\d{6}|\d{8})[-]{1}\d{4}$"))
                {
                    throw new ArgumentOutOfRangeException();
                }
                personalIdentityNumber = value;
            }
        }

        public List<Boat> RegisterBoat(float length, string boatType)
        {
            model.Boat newBoat = new model.Boat(length, boatType);
            BoatRegister.Add(newBoat);
            return BoatRegister;
        }                
    }       
}
