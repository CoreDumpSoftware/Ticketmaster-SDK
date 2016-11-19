using RestSharp;
using System.Net;
using System.Threading.Tasks;
using TM.Discovery.V2.Models;

namespace TM.Discovery.V2
{
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
            return SearchAttractionsAsync((IDiscoveryApiRequest)request);
        }

        public Task<SearchAttractionsResponse> SearchAttractionsAsync(IDiscoveryApiRequest request)
        {
            var searchRequest = new RestRequest(AttractionsPath, Method.GET) { RequestFormat = DataFormat.Json };
            return ExecuteRequestAsync<SearchAttractionsResponse>(searchRequest, HttpStatusCode.OK, request);
        }

        public Task<IRestResponse> CallSearchAttractionsAsync(SearchAttractionsRequest request)
        {
            return CallSearchAttractionsAsync((IDiscoveryApiRequest)request);
        }

        public Task<IRestResponse> CallSearchAttractionsAsync(IDiscoveryApiRequest request)
        {
            var searchRequest = new RestRequest(AttractionsPath, Method.GET) { RequestFormat = DataFormat.Json };
            return ExecuteRequestAsync(searchRequest, request);
        }

        public Task<Attraction> GetAttractionDetailsAsync(GetRequest request)
        {
            return GetAttractionDetailsAsync((IDiscoveryApiGetRequest)request);
        }

        public Task<Attraction> GetAttractionDetailsAsync(IDiscoveryApiGetRequest request)
        {
            var searchRequest = new RestRequest(AttractionsWithIdPath, Method.GET) { RequestFormat = DataFormat.Json };
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync<Attraction>(searchRequest, HttpStatusCode.OK, request);
        }

        public Task<IRestResponse> CallGetAttractionDetailsAsync(GetRequest request)
        {
            return CallGetAttractionDetailsAsync((IDiscoveryApiGetRequest)request);
        }

        public Task<IRestResponse> CallGetAttractionDetailsAsync(IDiscoveryApiGetRequest request)
        {
            var searchRequest = new RestRequest(AttractionsWithIdPath, Method.GET) { RequestFormat = DataFormat.Json };
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync(searchRequest, request);
        }
    }
}
