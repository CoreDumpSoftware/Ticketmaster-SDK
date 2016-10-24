
using RestSharp;
using System.Threading.Tasks;
using TM.Discovery.V2.Models;

namespace TM.Discovery.V2
{
    /// <summary>
    /// The IVenuesClient interface.
    /// </summary>
    public interface IVenuesClient
    {
        /// <summary>
        /// Gets the search venues.
        /// </summary>
        /// <param name="query">The <see cref="BaseQuery"/> query.</param>
        /// <returns>The <see cref="SearchEventsResponse"/>.</returns>
        Task<SearchVenuesResponse> SearchVenuesAsync(BaseQuery query);

        /// <summary>
        /// Calls the get search venues.
        /// </summary>
        /// <param name="query">The <see cref="BaseQuery"/> query.</param>
        /// <returns>The <see cref="IRestResponse"/>.</returns>
        Task<IRestResponse> CallSearchVenuesAsync(BaseQuery query);


        /// <summary>
        /// Gets the venue details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="Request"/> request.</param>
        /// <returns>The Task <see cref="Venue"/>.</returns>
        Task<Venue> GetVenueDetailsAsync(Request request);

        /// <summary>
        /// Calls the get venue details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="Request"/> request.</param>
        /// <returns>The Task <see cref="IRestResponse"/>.</returns>
        Task<IRestResponse> CallGetVenueDetailsAsync(Request request);
    }
}
