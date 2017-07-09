namespace Ticketmaster.Discovery.V2.Models
{
    using System.Collections.Generic;
    using Core;

    /// <summary>
    ///     The Venues class for current event.
    /// </summary>
    public class Venue : BaseEvent, IApiRespond
    {
        public Venue()
        {
            Markets = new List<Market>();
        }

        public string Timezone { get; set; }

        /// <summary>
        ///     Gets or sets the postal code.
        /// </summary>
        /// <value>
        ///     The postal code.
        /// </value>
        public string PostalCode { get; set; }

        /// <summary>
        ///     Gets or sets the city.
        /// </summary>
        /// <value>
        ///     The <see cref="Models.City" /> city.
        /// </value>
        public City City { get; set; }

        /// <summary>
        ///     Gets or sets the state.
        /// </summary>
        /// <value>
        ///     The <see cref="Models.State" /> state.
        /// </value>
        public State State { get; set; }

        /// <summary>
        ///     Gets or sets the country.
        /// </summary>
        /// <value>
        ///     The <see cref="Models.Country" /> country.
        /// </value>
        public Country Country { get; set; }

        /// <summary>
        ///     Gets or sets the address.
        /// </summary>
        /// <value>
        ///     The <see cref="Models.Address" /> address.
        /// </value>
        public Address Address { get; set; }

        /// <summary>
        ///     Gets or sets the location.
        /// </summary>
        /// <value>
        ///     The <see cref="Models.Location" /> location.
        /// </value>
        public Location Location { get; set; }

        /// <summary>
        ///     Gets or sets the _links.
        /// </summary>
        /// <value>
        ///     The <see cref="Models.Links" /> _links.
        /// </value>
        public Links Links { get; set; }

        /// <summary>
        ///     Gets or sets the markets.
        /// </summary>
        /// <value>
        ///     The markets.
        /// </value>
        public List<Market> Markets { get; set; }
    }
}