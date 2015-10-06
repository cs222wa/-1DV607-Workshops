using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.model
{
    class Boat
    {
        private float length;
        private string boatType;

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
        
        public Boat(float length, string boatType)
        {
            Length = length;
            BoatType = boatType;
        }
    }
}
