namespace Ticketmaster.Discovery.V2.Models
{
    public class SubGenre
    {
        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>
        ///     The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>
        ///     The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the links.
        /// </summary>
        /// <value>
        ///     The <see cref="Links" /> links.
        /// </value>
        public Links Links { get; set; }
    }
}