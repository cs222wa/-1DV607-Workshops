using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.model
{
    class Boat
    {
        private int length;

        public int Length
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

        public Boat()
        {

        }
    }
}
