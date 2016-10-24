
using System.Threading.Tasks;
using RestSharp;
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
        /// <param name="request">The <see cref="BaseQuery"/> request.</param>
        /// <returns>The <see cref="SearchAttractionsResponse"/>.</returns>
        Task<SearchAttractionsResponse> SearchAttractionsAsync(BaseQuery request);

        /// <summary>
        /// Calls the search attractions asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="BaseQuery"/> request.</param>
        /// <returns>The <see cref="IRestResponse"/>.</returns>
        Task<IRestResponse> CallSearchAttractionsAsync(BaseQuery request);

        /// <summary>
        /// Gets the attraction details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="BaseQuery"/> request.</param>
        /// <returns>The <see cref="Attraction"/>.</returns>
        Task<Attraction> GetAttractionDetailsAsync(Request request);

        /// <summary>
        /// Calls the get attraction details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="Request"/> request.</param>
        /// <returns>The <see cref="IRestResponse"/>.</returns>
        Task<IRestResponse> CallGetAttractionDetailsAsync(Request request);
    }
}
