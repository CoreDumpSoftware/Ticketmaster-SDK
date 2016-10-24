using System.Collections.Generic;

namespace TM.Discovery.V2.Models
{
    public class SearchAttractionsResponse : IDiscoveryApiRespond
    {
        public Embedded _embedded { get; set; }

        public Links Links { get; set; }

        public Page Page { get; set; }

        public class Embedded
        {
            public Embedded()
            {
                Attractions = new List<Attraction>();
            }

            public List<Attraction> Attractions { get; set; }
        }
    }
}
