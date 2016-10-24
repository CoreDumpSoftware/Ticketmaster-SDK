using RestSharp;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TM.Discovery.V2
{
    /// <summary>
    /// The BaseClient class.
    /// </summary>
    public abstract class BaseClient
    {
        private readonly IRestClient _client;
        private readonly IClientConfig _config;

        protected BaseClient(
            IRestClient client,
            IClientConfig config)
        {
            _client = client;
            _config = config;
        }

        /// <summary>
        /// Validates the response.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="expectedCode">The <see cref="HttpStatusCode"/>.</param>
        /// Throw <exception cref="System.IO.InvalidDataException"> when StatusCode not expected.</exception>
        protected virtual void ValidateResponse(IRestResponse response, HttpStatusCode expectedCode)
        {
            if (response.StatusCode == expectedCode) return;

            var exceptionBuilder = new StringBuilder();
            exceptionBuilder.AppendLine("Invalid respond fro the server.");
            exceptionBuilder.AppendLine("Current Status Code:" + response.StatusCode);
            exceptionBuilder.AppendLine("Error Message:" + response.ErrorMessage);
            throw new InvalidDataException(exceptionBuilder.ToString());
        }

        /// <summary>
        /// Adds the Query to request.
        /// </summary>
        /// <param name="request">The <see cref="IRestRequest"/> request.</param>
        /// <param name="query">The <see cref="BaseQuery"/> query.</param>
        protected void AddQuiriesToRequest(ref IRestRequest request, BaseQuery query)
        {
            if (query == null) return;

            foreach (var parameter in query.QueryParameters)
            {
                request.AddParameter(parameter.Key, parameter.Value, ParameterType.QueryString);
            }
            request.AddParameter("apikey", _config.ConsumerKey, ParameterType.QueryString);
        }

        /// <summary>
        /// Executes the request asynchronous.
        /// </summary>
        /// <typeparam name="T">Type of expected response.</typeparam>
        /// <param name="request">The request.</param>
        /// <param name="expectedStatusCode">The expected status code.</param>
        /// <param name="query">The <see cref="BaseQuery"/>.</param>
        /// <returns></returns>
        protected async Task<T> ExecuteRequestAsync<T>(
            IRestRequest request,
            HttpStatusCode expectedStatusCode,
            BaseQuery query = null)
            where T : IDiscoveryApiRespond
        {
            AddQuiriesToRequest(ref request, query);
            var response = await _client.ExecuteTaskAsync<T>(request);
            ValidateResponse(response, expectedStatusCode);
            return response.Data;
        }

        /// <summary>
        /// Executes the request asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="expectedStatusCode">The expected <see cref="HttpStatusCode"/> status code.</param>
        /// <param name="query">The <see cref="BaseQuery"/> query.</param>
        /// <returns>The <see cref="IRestResponse"/> object.</returns>
        protected async Task<IRestResponse> ExecuteRequestAsync(
            IRestRequest request,
            BaseQuery query = null)
        {
            AddQuiriesToRequest(ref request, query);
            var response = await _client.ExecuteTaskAsync(request);
            return response;
        }
    }
}
