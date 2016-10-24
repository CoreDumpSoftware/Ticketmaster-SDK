using System.Collections.Generic;

namespace TM.Discovery.V2.Models
{
    /// <summary>
    /// The Segment class.
    /// </summary>
    public class Segment
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        /// <value>
        /// The links.
        /// </value>
        public Links Links { get; set; }

        /// <summary>
        /// Gets or sets the embedded.
        /// </summary>
        /// <value>
        /// The <see cref="Embedded"/> embedded.
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
