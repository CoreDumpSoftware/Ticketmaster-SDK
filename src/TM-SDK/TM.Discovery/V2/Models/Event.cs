namespace Ticketmaster.Discovery.V2.Models
{
    using System.Collections.Generic;

    public class Event : BaseEvent, IDiscoveryApiRespond
    {
        public string Description { get; set; }
        public Sales Sales { get; set; }
        public Links Links { get; set; }
        public Embedded _embedded { get; set; }

        public class Embedded
        {
            public Embedded()
            {
                Venues = new List<Venue>();
            }

            public List<Venue> Venues { get; set; }
        }
    }
}