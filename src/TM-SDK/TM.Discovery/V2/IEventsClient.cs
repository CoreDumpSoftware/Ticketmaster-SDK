
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
        /// <param name="request">The request.</param>
        /// <returns>The task for <see cref="SearchEventsResponse"/>.</returns>
        Task<SearchEventsResponse> SearchEventsAsync(BaseQuery request);

        /// <summary>
        /// Calls the search events asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>The <see cref="IRestResponse"/>.</returns>
        Task<IRestResponse> CallSearchEventsAsync(BaseQuery request);

        /// <summary>
        /// Gets the event details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="Request"/>.</param>
        /// <returns>The task for <see cref="Event"/>.</returns>
        Task<Event> GetEventDetailsAsync(Request request);

        /// <summary>
        /// Calls the get event details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="Request"/> request.</param>
        /// <returns>The Task <see cref="IRestResponse"/>.</returns>
        Task<IRestResponse> CallGetEventDetailsAsync(Request request);

        /// <summary>
        /// Gets the event images asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="Request"/>.</param>
        /// <returns>The Task for <see cref="GetEventImagesResponse"/>.</returns>
        Task<GetEventImagesResponse> GetEventImagesAsync(Request request);

        /// <summary>
        /// Calls the get event images asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>The Task for <see cref="IRestResponse"/>.</returns>
        Task<IRestResponse> CallGetEventImagesAsync(Request request);
    }
}
