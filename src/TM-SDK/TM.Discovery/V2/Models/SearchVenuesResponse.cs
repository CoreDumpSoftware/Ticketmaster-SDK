namespace Ticketmaster.Discovery.V2.Models
{
    using System.Collections.Generic;

    public class SearchVenuesResponse : IDiscoveryApiRespond
    {
        public Embedded _embedded { get; set; }

        public Links Links { get; set; }

        public Page Page { get; set; }

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