namespace Ticketmaster.Discovery.V2.Models
{
    using System.Collections.Generic;

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