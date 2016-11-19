
using RestSharp;
using System.Threading.Tasks;
using TM.Discovery.V2.Models;

namespace TM.Discovery.V2
{
    /// <summary>
    /// The IAttractionsClient interface.
    /// </summary>
    public interface IAttractionsClient
    {
        /// <summary>
        /// Searches the attractions asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="SearchAttractionsRequest"/> request.</param>
        /// <returns>The <see cref="SearchAttractionsResponse"/>.</returns>
        Task<SearchAttractionsResponse> SearchAttractionsAsync(SearchAttractionsRequest request);

        /// <summary>
        /// Searches the attractions asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="IDiscoveryApiRequest"/> request.</param>
        /// <returns>The <see cref="SearchAttractionsResponse"/>.</returns>
        Task<SearchAttractionsResponse> SearchAttractionsAsync(IDiscoveryApiRequest request);

        /// <summary>
        /// Calls the search attractions asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="SearchAttractionsRequest"/> request.</param>
        /// <returns>The <see cref="IRestResponse"/>.</returns>
        Task<IRestResponse> CallSearchAttractionsAsync(SearchAttractionsRequest request);

        /// <summary>
        /// Calls the search attractions asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="IDiscoveryApiRequest"/> request.</param>
        /// <returns>The <see cref="IRestResponse"/>.</returns>
        Task<IRestResponse> CallSearchAttractionsAsync(IDiscoveryApiRequest request);

        /// <summary>
        /// Gets the attraction details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="GetRequest"/> request.</param>
        /// <returns>The <see cref="Attraction"/>.</returns>
        Task<Attraction> GetAttractionDetailsAsync(GetRequest request);

        /// <summary>
        /// Gets the attraction details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="IDiscoveryApiGetRequest"/> request.</param>
        /// <returns>The <see cref="Attraction"/>.</returns>
        Task<Attraction> GetAttractionDetailsAsync(IDiscoveryApiGetRequest request);

        /// <summary>
        /// Calls the get attraction details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="GetRequest"/> request.</param>
        /// <returns>The <see cref="IRestResponse"/>.</returns>
        Task<IRestResponse> CallGetAttractionDetailsAsync(GetRequest request);

        /// <summary>
        /// Calls the get attraction details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="IDiscoveryApiGetRequest"/> request.</param>
        /// <returns>The <see cref="IRestResponse"/>.</returns>
        Task<IRestResponse> CallGetAttractionDetailsAsync(IDiscoveryApiGetRequest request);
    }
}
