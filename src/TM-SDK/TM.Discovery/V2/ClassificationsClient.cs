using RestSharp;
using System.Net;
using System.Threading.Tasks;
using TM.Discovery.V2.Models;

namespace TM.Discovery.V2
{
    public class ClassificationsClient : BaseClient, IClassificationsClient
    {
        private const string ClassificationsPath = "/v2/classifications.json";
        private const string ClassificationsPathWithId = "/v2/classifications/{id}.json";

        public ClassificationsClient(IRestClient client, IClientConfig config)
            : base(client, config)
        {
        }

        public Task<SearchClassificationsResponse> SearchClassificationsAsync(SearchClassificationsRequest request)
        {
            return SearchClassificationsAsync((IDiscoveryApiRequest)request);
        }

        public Task<SearchClassificationsResponse> SearchClassificationsAsync(IDiscoveryApiRequest request)
        {
            var searchRequest = new RestRequest(ClassificationsPath, Method.GET) { RequestFormat = DataFormat.Json };
            return ExecuteRequestAsync<SearchClassificationsResponse>(searchRequest, HttpStatusCode.OK, request);
        }

        public Task<IRestResponse> CallSearchClassificationsAsync(SearchClassificationsRequest request)
        {
            return CallSearchClassificationsAsync((IDiscoveryApiRequest)request);
        }

        public Task<IRestResponse> CallSearchClassificationsAsync(IDiscoveryApiRequest request)
        {
            var searchRequest = new RestRequest(ClassificationsPath, Method.GET) { RequestFormat = DataFormat.Json };
            return ExecuteRequestAsync(searchRequest, request);
        }

        public Task<Classification> GetClassificationDetailsAsync(GetRequest request)
        {
            return GetClassificationDetailsAsync((IDiscoveryApiGetRequest)request);
        }

        public Task<Classification> GetClassificationDetailsAsync(IDiscoveryApiGetRequest request)
        {
            var searchRequest = new RestRequest(ClassificationsPathWithId, Method.GET) { RequestFormat = DataFormat.Json };
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync<Classification>(searchRequest, HttpStatusCode.OK, request);
        }

        public Task<IRestResponse> CallGetClassificationDetailsAsync(GetRequest request)
        {
            return CallGetClassificationDetailsAsync((IDiscoveryApiGetRequest)request);
        }

        public Task<IRestResponse> CallGetClassificationDetailsAsync(IDiscoveryApiGetRequest request)
        {
            var searchRequest = new RestRequest(ClassificationsPathWithId, Method.GET) { RequestFormat = DataFormat.Json };
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync(searchRequest, request);
        }
    }
}
