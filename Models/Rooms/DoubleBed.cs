using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Models.Rooms
{
    public class DoubleBed : Room
    {
        private const int DoubleBedBedCapacity = 2; // Must no be with the same name of the property, cuz of hiding it !
        public DoubleBed() 
            : base(DoubleBedBedCapacity)
        {

        }

    }
}
