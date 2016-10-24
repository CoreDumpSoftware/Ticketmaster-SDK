using System.Collections.Generic;
using TM.Discovery.V2.Models;

namespace TM.Discovery.V2
{
    public class SearchClassificationsResponse : IDiscoveryApiRespond
    {
        public Embedded _embedded { get; set; }

        public Links Links { get; set; }
        public Page Page { get; set; }

        public class Embedded
        {
            public Embedded()
            {
                Classifications = new List<Classification>();
            }
            public List<Classification> Classifications { get; set; }
        }
    }
}
