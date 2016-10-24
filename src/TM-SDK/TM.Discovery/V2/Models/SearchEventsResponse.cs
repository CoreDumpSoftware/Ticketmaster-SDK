using System.Collections.Generic;

namespace TM.Discovery.V2.Models
{
    /// <summary>
    /// The Get Events Response class.
    /// </summary>
    public class SearchEventsResponse : IDiscoveryApiRespond
    {
        /// <summary>
        /// Gets or sets the _embedded.
        /// </summary>
        /// <value>
        /// The <see cref="Embedded"/> _embedded.
        /// </value>
        public Embedded _embedded { get; set; }

        /// <summary>
        /// Gets or sets the _links.
        /// </summary>
        /// <value>
        /// The <see cref="Models.Links"/> _links.
        /// </value>
        public Links Links { get; set; }

        /// <summary>
        /// Gets or sets the page.
        /// </summary>
        /// <value>
        /// The <see cref="Models.Page"/> page.
        /// </value>
        public Page Page { get; set; }

        /// <summary>
        /// The Embedded class for current response type.
        /// </summary>
        public class Embedded
        {
            public Embedded()
            {
                events = new List<Event>();
            }

            public List<Event> events { get; set; }
        }
    }
}
