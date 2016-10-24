using RestSharp;
using System.Threading.Tasks;
using TM.Discovery.V2.Models;

namespace TM.Discovery.V2
{
    /// <summary>
    /// The IClassificationsClient Interface.
    /// </summary>
    public interface IClassificationsClient
    {
        /// <summary>
        /// Searches the classifications asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>The <see cref="SearchClassificationsResponse"/>.</returns>
        Task<SearchClassificationsResponse> SearchClassificationsAsync(BaseQuery request);

        /// <summary>
        /// Calls the search classifications asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="BaseQuery"/> request.</param>
        /// <returns>The <see cref="IRestResponse"/>.</returns>
        Task<IRestResponse> CallSearchClassificationsAsync(BaseQuery request);

        /// <summary>
        /// Gets the classification details asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>The <see cref="Classification"/>.</returns>
        Task<Classification> GetClassificationDetailsAsync(Request request);

        /// <summary>
        /// Calls the get classification details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="Request"/> request.</param>
        /// <returns>The <see cref="Classification"/>.</returns>
        Task<IRestResponse> CallGetClassificationDetailsAsync(Request request);
    }
}
