using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.model
{
    class Boat
    {
        private double length;
        model.MemberRegister mr;
        view.Console v;
        
        public double Length
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
            mr = new model.MemberRegister();
            v = new view.Console();
        }

        //public void RegisterBoat()
        //{
        //    mr.ListMembersCompact();
        //    v.AskForMember("register boat for ");
        //    string choosenMember = mr.HandleMember(Console.ReadLine());
        //    Console.WriteLine("Boat registered");
        //    v.Continue();
        //}
    }
}
