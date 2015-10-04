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
        private BoatType type;
        
        public float Length
        {
            get { return length; }
            set { length = value; }
        }
        enum BoatType
        {
            Sailboat,
            Motorsailor,
            Kayak_Canoe,
            Other
        }

       // public Boat(int memberId, double length, BoatType type)
        public Boat(int memberId, double length, string boatType)
        {

        }

        //public Boat()
        //{
        //    memberId = 0;
        //    length = 0;
        //    type = Other; 
        //}

        
    }
}
