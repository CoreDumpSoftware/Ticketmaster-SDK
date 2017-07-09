namespace Ticketmaster.Discovery.V2
{
    using System.Net;
    using System.Threading.Tasks;
    using Core;
    using Models;
    using RestSharp;

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
            return SearchClassificationsAsync((IApiRequest) request);
        }

        public Task<SearchClassificationsResponse> SearchClassificationsAsync(IApiRequest request)
        {
            var searchRequest = new RestRequest(ClassificationsPath, Method.GET) {RequestFormat = DataFormat.Json};
            return ExecuteRequestAsync<SearchClassificationsResponse>(searchRequest, HttpStatusCode.OK, request);
        }

        public Task<IRestResponse> CallSearchClassificationsAsync(SearchClassificationsRequest request)
        {
            return CallSearchClassificationsAsync((IApiRequest) request);
        }

        public Task<IRestResponse> CallSearchClassificationsAsync(IApiRequest request)
        {
            var searchRequest = new RestRequest(ClassificationsPath, Method.GET) {RequestFormat = DataFormat.Json};
            return ExecuteRequestAsync(searchRequest, request);
        }

        public Task<Classification> GetClassificationDetailsAsync(GetRequest request)
        {
            return GetClassificationDetailsAsync((IApiGetRequest) request);
        }

        public Task<Classification> GetClassificationDetailsAsync(IApiGetRequest request)
        {
            var searchRequest =
                new RestRequest(ClassificationsPathWithId, Method.GET) {RequestFormat = DataFormat.Json};
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync<Classification>(searchRequest, HttpStatusCode.OK, request);
        }

        public Task<IRestResponse> CallGetClassificationDetailsAsync(GetRequest request)
        {
            return CallGetClassificationDetailsAsync((IApiGetRequest) request);
        }

        public Task<IRestResponse> CallGetClassificationDetailsAsync(IApiGetRequest request)
        {
            var searchRequest =
                new RestRequest(ClassificationsPathWithId, Method.GET) {RequestFormat = DataFormat.Json};
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync(searchRequest, request);
        }
    }
}