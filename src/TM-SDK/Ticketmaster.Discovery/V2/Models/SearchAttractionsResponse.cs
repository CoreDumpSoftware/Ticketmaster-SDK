namespace Ticketmaster.Discovery.V2.Models
{
    using System.Collections.Generic;
    using Core;

    public class SearchAttractionsResponse : IApiRespond
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