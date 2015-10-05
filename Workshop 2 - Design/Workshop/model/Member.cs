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
        List<Boat> boatRegister = new List<Boat>();

        internal List<Boat> BoatRegister
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
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
                name = value;
            }
        }

        public string PersonalIdentityNumber
        {
            get { return personalIdentityNumber; }
            set
            {
                //try
                //{
                    if (String.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentNullException();
                    }
                    if (!Regex.IsMatch(value, @"^(\d{6}|\d{8})[-|(\s)]{0,1}\d{4}$"))
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    personalIdentityNumber = value;
                //}
                //catch (ArgumentException)
                //{
                //    v.ViewErrorMessage("Personal identity number is not valid. Press any key to try again.");                    
                //}
            }
        }        

        

        public Member()                 //??
        {

        }
        public Member(int id, string name, string personalIdentityNumber, List<Boat> boatList)
            //public Member(int id, string name, string personalIdentityNumber)
        {
            Id = id;
            Name = name;
            PersonalIdentityNumber = personalIdentityNumber;
        }

       
        public List<Boat> RegisterBoat(float length, string boatType)
        {
            model.Boat newBoat = new model.Boat(length, boatType);
            BoatRegister.Add(newBoat);
            return BoatRegister;
        }

        
    }       
}
