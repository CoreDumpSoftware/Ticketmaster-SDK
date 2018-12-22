namespace Ticketmaster.Commerce.V2
{
    using Core;
    using Models;
    using RestSharp;
    using System.Threading.Tasks;

    /// <summary>
    /// The IEventOffersClient Interface.
    /// </summary>
    public interface IEventOffersClient
    {
        /// <summary>
        /// Gets the event offers asynchronously.
        /// </summary>
        /// <param name="getRequest">The <see cref="GetRequest"/> request.</param>
        /// <returns>The Task for <see cref="EventOffers"/>.</returns>
        Task<EventOffers> GetEventOffersAsync(GetRequest getRequest);

        /// <summary>
        /// Calls the get event offers asynchronously.
        /// </summary>
        /// <param name="getRequest">The <see cref="GetRequest"/> request.</param>
        /// <returns>The Task for <see cref="IRestResponse"/>.</returns>
        Task<IRestResponse> CallGetEventOffersAsync(GetRequest getRequest);

        /// <summary>
        /// Gets the event offers asynchronously.
        /// </summary>
        /// <param name="getRequest">The <see cref="IApiGetRequest"/> request.</param>
        /// <returns>The Task for <see cref="EventOffers"/>.</returns>
        Task<EventOffers> GetEventOffersAsync(IApiGetRequest getRequest);

        /// <summary>
        /// Calls the get event offers asynchronously.
        /// </summary>
        /// <param name="getRequest">The <see cref="IApiGetRequest"/> request.</param>
        /// <returns>The Task for <see cref="IRestResponse"/>.</returns>
        Task<IRestResponse> CallGetEventOffersAsync(IApiGetRequest getRequest);
    }
}
