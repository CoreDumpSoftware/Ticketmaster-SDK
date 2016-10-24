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

        public Task<SearchAttractionsResponse> SearchAttractionsAsync(BaseQuery request)
        {
            var searchRequest = new RestRequest(AttractionsPath, Method.GET) { RequestFormat = DataFormat.Json };
            return ExecuteRequestAsync<SearchAttractionsResponse>(searchRequest, HttpStatusCode.OK, request);
        }

        public Task<IRestResponse> CallSearchAttractionsAsync(BaseQuery request)
        {
            var searchRequest = new RestRequest(AttractionsPath, Method.GET) { RequestFormat = DataFormat.Json };
            return ExecuteRequestAsync(searchRequest, request);
        }

        public Task<Attraction> GetAttractionDetailsAsync(Request request)
        {
            var searchRequest = new RestRequest(AttractionsWithIdPath, Method.GET) { RequestFormat = DataFormat.Json };
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync<Attraction>(searchRequest, HttpStatusCode.OK, request);
        }

        public Task<IRestResponse> CallGetAttractionDetailsAsync(Request request)
        {
            var searchRequest = new RestRequest(AttractionsWithIdPath, Method.GET) { RequestFormat = DataFormat.Json };
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync(searchRequest,request);
        }
    }
}
