using RestSharp;
using System.Threading.Tasks;
using TM.Discovery.V2.Models;

namespace TM.Discovery.V2
{
    /// <summary>
    /// The IEventsClient interface.
    /// </summary>
    public interface IEventsClient
    {
        /// <summary>
        /// Searches the events asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="SearchEventsRequest"/> request.</param>
        /// <returns>The task for <see cref="SearchEventsResponse"/>.</returns>
        Task<SearchEventsResponse> SearchEventsAsync(SearchEventsRequest request);

        /// <summary>
        /// Searches the events asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="IDiscoveryApiRequest"/> request.</param>
        /// <returns>The task for <see cref="SearchEventsResponse"/>.</returns>
        Task<SearchEventsResponse> SearchEventsAsync(IDiscoveryApiRequest request);

        /// <summary>
        /// Calls the search events asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="SearchEventsRequest"/> request.</param>
        /// <returns>The <see cref="IRestResponse"/>.</returns>
        Task<IRestResponse> CallSearchEventsAsync(SearchEventsRequest request);

        /// <summary>
        /// Calls the search events asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="IDiscoveryApiRequest"/> request.</param>
        /// <returns>The <see cref="IRestResponse"/>.</returns>
        Task<IRestResponse> CallSearchEventsAsync(IDiscoveryApiRequest request);

        /// <summary>
        /// Gets the event details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="GetRequest"/>.</param>
        /// <returns>The task for <see cref="Event"/>.</returns>
        Task<Event> GetEventDetailsAsync(GetRequest request);

        /// <summary>
        /// Gets the event details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="IDiscoveryApiGetRequest"/>.</param>
        /// <returns>The task for <see cref="Event"/>.</returns>
        Task<Event> GetEventDetailsAsync(IDiscoveryApiGetRequest request);

        /// <summary>
        /// Calls the get event details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="GetRequest"/> request.</param>
        /// <returns>The Task <see cref="IRestResponse"/>.</returns>
        Task<IRestResponse> CallGetEventDetailsAsync(GetRequest request);

        /// <summary>
        /// Calls the get event details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="IDiscoveryApiGetRequest"/> request.</param>
        /// <returns>The Task <see cref="IRestResponse"/>.</returns>
        Task<IRestResponse> CallGetEventDetailsAsync(IDiscoveryApiGetRequest request);

        /// <summary>
        /// Gets the event images asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="GetRequest"/>.</param>
        /// <returns>The Task for <see cref="GetEventImagesResponse"/>.</returns>
        Task<GetEventImagesResponse> GetEventImagesAsync(GetRequest request);

        /// <summary>
        /// Gets the event images asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="IDiscoveryApiGetRequest"/>.</param>
        /// <returns>The Task for <see cref="GetEventImagesResponse"/>.</returns>
        Task<GetEventImagesResponse> GetEventImagesAsync(IDiscoveryApiGetRequest request);

        /// <summary>
        /// Calls the get event images asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="GetRequest"/> request.</param>
        /// <returns>The Task for <see cref="IRestResponse"/>.</returns>
        Task<IRestResponse> CallGetEventImagesAsync(GetRequest request);

        /// <summary>
        /// Calls the get event images asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="IDiscoveryApiRequest"/> request.</param>
        /// <returns>The Task for <see cref="IRestResponse"/>.</returns>
        Task<IRestResponse> CallGetEventImagesAsync(IDiscoveryApiGetRequest request);
    }
}
