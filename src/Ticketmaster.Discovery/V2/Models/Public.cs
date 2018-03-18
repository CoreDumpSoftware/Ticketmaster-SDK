namespace Ticketmaster.Discovery.V2.Models
{
    using System;

    /// <summary>
    ///     The class for public information for sales.
    /// </summary>
    public class Public
    {
        /// <summary>
        ///     Gets or sets the start date time.
        /// </summary>
        /// <value>
        ///     The start date time.
        /// </value>
        public DateTime StartDateTime { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether [start TBD].
        /// </summary>
        /// <value>
        ///     <c>true</c> if [start TBD]; otherwise, <c>false</c>.
        /// </value>
        public bool StartTbd { get; set; }

        /// <summary>
        ///     Gets or sets the end date time.
        /// </summary>
        /// <value>
        ///     The end date time.
        /// </value>
        public DateTime EndDateTime { get; set; }
    }
}