namespace Ticketmaster.Discovery.V2
{
    using System.Threading.Tasks;
    using Models;
    using RestSharp;

    /// <summary>
    ///     The IClassificationsClient Interface.
    /// </summary>
    public interface IClassificationsClient
    {
        /// <summary>
        ///     Searches the classifications asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="SearchClassificationsRequest" /> request.</param>
        /// <returns>The <see cref="SearchClassificationsResponse" />.</returns>
        Task<SearchClassificationsResponse> SearchClassificationsAsync(SearchClassificationsRequest request);

        /// <summary>
        ///     Searches the classifications asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="IDiscoveryApiRequest" /> request.</param>
        /// <returns>The <see cref="SearchClassificationsResponse" />.</returns>
        Task<SearchClassificationsResponse> SearchClassificationsAsync(IDiscoveryApiRequest request);

        /// <summary>
        ///     Calls the search classifications asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="SearchClassificationsRequest" /> request.</param>
        /// <returns>The <see cref="IRestResponse" />.</returns>
        Task<IRestResponse> CallSearchClassificationsAsync(SearchClassificationsRequest request);

        /// <summary>
        ///     Calls the search classifications asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="IDiscoveryApiRequest" /> request.</param>
        /// <returns>The <see cref="IRestResponse" />.</returns>
        Task<IRestResponse> CallSearchClassificationsAsync(IDiscoveryApiRequest request);

        /// <summary>
        ///     Gets the classification details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="GetRequest" /> request.</param>
        /// <returns>The <see cref="Classification" />.</returns>
        Task<Classification> GetClassificationDetailsAsync(GetRequest request);

        /// <summary>
        ///     Gets the classification details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="IDiscoveryApiGetRequest" /> request.</param>
        /// <returns>The <see cref="Classification" />.</returns>
        Task<Classification> GetClassificationDetailsAsync(IDiscoveryApiGetRequest request);

        /// <summary>
        ///     Calls the get classification details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="GetRequest" /> request.</param>
        /// <returns>The <see cref="Classification" />.</returns>
        Task<IRestResponse> CallGetClassificationDetailsAsync(GetRequest request);

        /// <summary>
        ///     Calls the get classification details asynchronous.
        /// </summary>
        /// <param name="request">The <see cref="IDiscoveryApiGetRequest" /> request.</param>
        /// <returns>The <see cref="Classification" />.</returns>
        Task<IRestResponse> CallGetClassificationDetailsAsync(IDiscoveryApiGetRequest request);
    }
}