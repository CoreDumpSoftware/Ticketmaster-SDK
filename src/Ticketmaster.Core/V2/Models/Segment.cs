namespace Ticketmaster.Core.V2.Models
{
    using System.Collections.Generic;
    using Core;

    /// <summary>
    ///     The Segment class.
    /// </summary>
    public class Segment : IdNamePair
    {
        /// <summary>
        ///     Gets or sets the links.
        /// </summary>
        /// <value>
        ///     The links.
        /// </value>
        public Links Links { get; set; }

        /// <summary>
        ///     Gets or sets the embedded.
        /// </summary>
        /// <value>
        ///     The <see cref="Embedded" /> embedded.
        /// </value>
        public Embedded _embedded { get; set; }

        public class Embedded
        {
            public Embedded()
            {
                Genres = new List<Genre>();
            }

            public List<Genre> Genres { get; set; }
        }
    }
}