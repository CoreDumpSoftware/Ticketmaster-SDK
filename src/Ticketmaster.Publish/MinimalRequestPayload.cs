namespace Ticketmaster.Publish
{
    using Core;
    using Core.V2.Models;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="MinimalRequestPayload" />
    /// </summary>
    public class MinimalRequestPayload : IApiRequest
    {
        /// <summary>
        /// Gets the QueryParameters
        /// </summary>
        public IEnumerable<KeyValuePair<string, string>> QueryParameters => null;

        /// <summary>
        /// Gets or sets the Source
        /// </summary>
        public IdNamePair Source { get; protected set; }

        /// <summary>
        /// Gets or sets a value indicating whether Test
        /// </summary>
        public bool Test { get; protected set; }

        /// <summary>
        /// Gets or sets the Names
        /// </summary>
        public dynamic Names { get; protected set; }

        /// <summary>
        /// Gets or sets the PublicVisibility
        /// </summary>
        public Visibility PublicVisibility { get; protected set; }

        /// <summary>
        /// Gets or sets the Dates
        /// </summary>
        public Dates Dates { get; protected set; }
    }
}
