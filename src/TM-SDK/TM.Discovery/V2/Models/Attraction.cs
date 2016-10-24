
using System.Collections.Generic;

namespace TM.Discovery.V2.Models
{
    public class Attraction : BaseEvent, IDiscoveryApiRespond
    {
        public Attraction()
        {
            Classifications = new List<Classification>();
        }


        public List<Classification> Classifications { get; set; }

        public Links Links { get; set; }
    }
}
