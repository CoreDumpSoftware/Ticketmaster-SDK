namespace Ticketmaster.Discovery.V2.Models
{
    using System.Collections.Generic;

    /// <summary>
    ///     The Links class.
    /// </summary>
    public class Links
    {
        public Links()
        {
            Venues = new List<Link>();
        }

        /// <summary>
        ///     Gets or sets the self link string.
        /// </summary>
        /// <value>
        ///     The self link.
        /// </value>
        public Link Self { get; set; }

        /// <summary>
        ///     Gets or sets the link for next.
        /// </summary>
        /// <value>
        ///     The next link.
        /// </value>
        public Link Next { get; set; }

        /// <summary>
        ///     Gets or sets the venues.
        /// </summary>
        /// <value>
        ///     The venues.
        /// </value>
        public List<Link> Venues { get; set; }
    }
}