namespace Ticketmaster.Discovery.V2
{
    using System.Threading.Tasks;
    using Models;
    using RestSharp;

    /// <summary>
    ///     The IVenuesClient interface.
    /// </summary>
    public interface IVenuesClient
    {
        /// <summary>
        ///     Gets the search venues.
        /// </summary>
        /// <param name="query">The <see cref="SearchVenuesRequest" /> query.</param>
        /// <returns>The <see cref="SearchEventsResponse" />.</returns>
        Task<SearchVenuesResponse> SearchVenuesAsync(SearchVenuesRequest query);

        /// <summary>
        ///     Gets the search venues.
        /// </summary>
        /// <param name="query">The <see cref="IDiscoveryApiRequest" /> query.</param>
        /// <returns>The <see cref="SearchEventsResponse" />.</returns>
        Task<SearchVenuesResponse> SearchVenuesAsync(IDiscoveryApiRequest query);

        /// <summary>
        ///     Calls the get search venues.
        /// </summary>
        /// <param name="query">The <see cref="SearchVenuesRequest" /> query.</param>
        /// <returns>The <see cref="IRestResponse" />.</returns>
        Task<IRestResponse> CallSearchVenuesAsync(SearchVenuesRequest query);

        /// <summary>
        ///     Calls the get search venues.
        /// </summary>
        /// <param name="query">The <see cref="IDiscoveryApiRequest" /> query.</param>
        /// <returns>The <see cref="IRestResponse" />.</returns>
        Task<IRestResponse> CallSearchVenuesAsync(IDiscoveryApiRequest query);


        /// <summary>
        ///     Gets the venue details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="GetRequest" /> request.</param>
        /// <returns>The Task <see cref="Venue" />.</returns>
        Task<Venue> GetVenueDetailsAsync(GetRequest request);

        /// <summary>
        ///     Gets the venue details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="IDiscoveryApiGetRequest" /> request.</param>
        /// <returns>The Task <see cref="Venue" />.</returns>
        Task<Venue> GetVenueDetailsAsync(IDiscoveryApiGetRequest request);

        /// <summary>
        ///     Calls the get venue details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="GetRequest" /> request.</param>
        /// <returns>The Task <see cref="IRestResponse" />.</returns>
        Task<IRestResponse> CallGetVenueDetailsAsync(GetRequest request);

        /// <summary>
        ///     Calls the get venue details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="IDiscoveryApiGetRequest" /> request.</param>
        /// <returns>The Task <see cref="IRestResponse" />.</returns>
        Task<IRestResponse> CallGetVenueDetailsAsync(IDiscoveryApiGetRequest request);
    }
}