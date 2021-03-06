using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    /// <summary>
    /// Ride Class To Set Data For Particular Ride.
    /// </summary>
    public class Ride
    {
        //Variables.
        public double distance;
        public int time;
        /// <summary>
        /// Parameter Constructor for Setting Data.
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="time"></param>
        public Ride(double distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}