using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.model
{
    class Boat
    {
        private int memberId;
        private float length;
        private string boatType;
        //private BoatType type;
        public string BoatType
        {
            get { return boatType; }
            set { boatType = value; }
        }               
        public float Length
        {
            get { return length; }
            set { length = value; }
        }
        //enum BoatType
        //{
        //    Sailboat,
        //    Motorsailor,
        //    Kayak_Canoe,
        //    Other
        //}

       // public Boat(int memberId, float length, BoatType type)
        public Boat(int memberId, float length, string boatType)
        {
            Length = length;
            BoatType = boatType;
        }
    }
}
