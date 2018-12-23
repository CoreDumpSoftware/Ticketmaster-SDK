namespace Ticketmaster.Core.V2.Models
{
    using System;

    /// <summary>
    /// Defines the <see cref="Visibility" />
    /// </summary>
    public class Visibility
    {
        /// <summary>
        /// Gets or sets the Start Date Time
        /// </summary>
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Visible
        /// </summary>
        public bool Visible { get; set; }
    }
}
