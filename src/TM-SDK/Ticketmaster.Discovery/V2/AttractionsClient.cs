namespace Ticketmaster.Discovery.V2
{
    using System.Net;
    using System.Threading.Tasks;
    using Core;
    using Models;
    using RestSharp;

    public class AttractionsClient : BaseClient, IAttractionsClient
    {
        private const string AttractionsPath = "/v2/attractions.json";
        private const string AttractionsWithIdPath = "/v2/attractions/{id}.json";

        public AttractionsClient(IRestClient client, IClientConfig config)
            : base(client, config)
        {
        }

        public Task<SearchAttractionsResponse> SearchAttractionsAsync(SearchAttractionsRequest request)
        {
            return SearchAttractionsAsync((IApiRequest) request);
        }

        public Task<SearchAttractionsResponse> SearchAttractionsAsync(IApiRequest request)
        {
            var searchRequest = new RestRequest(AttractionsPath, Method.GET) {RequestFormat = DataFormat.Json};
            return ExecuteRequestAsync<SearchAttractionsResponse>(searchRequest, HttpStatusCode.OK, request);
        }

        public Task<IRestResponse> CallSearchAttractionsAsync(SearchAttractionsRequest request)
        {
            return CallSearchAttractionsAsync((IApiRequest) request);
        }

        public Task<IRestResponse> CallSearchAttractionsAsync(IApiRequest request)
        {
            var searchRequest = new RestRequest(AttractionsPath, Method.GET) {RequestFormat = DataFormat.Json};
            return ExecuteRequestAsync(searchRequest, request);
        }

        public Task<Attraction> GetAttractionDetailsAsync(GetRequest request)
        {
            return GetAttractionDetailsAsync((IApiGetRequest) request);
        }

        public Task<Attraction> GetAttractionDetailsAsync(IApiGetRequest request)
        {
            var searchRequest = new RestRequest(AttractionsWithIdPath, Method.GET) {RequestFormat = DataFormat.Json};
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync<Attraction>(searchRequest, HttpStatusCode.OK, request);
        }

        public Task<IRestResponse> CallGetAttractionDetailsAsync(GetRequest request)
        {
            return CallGetAttractionDetailsAsync((IApiGetRequest) request);
        }

        public Task<IRestResponse> CallGetAttractionDetailsAsync(IApiGetRequest request)
        {
            var searchRequest = new RestRequest(AttractionsWithIdPath, Method.GET) {RequestFormat = DataFormat.Json};
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync(searchRequest, request);
        }
    }
}