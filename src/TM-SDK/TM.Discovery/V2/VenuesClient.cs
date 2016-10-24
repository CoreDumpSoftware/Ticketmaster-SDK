
using RestSharp;
using System.Net;
using System.Threading.Tasks;
using TM.Discovery.V2.Models;

namespace TM.Discovery.V2
{
    public class VenuesClient : BaseClient, IVenuesClient
    {
        private readonly string VenuesPath = "/v2/venues.json";
        private readonly string VenuesWithIdPath = "/v2/venues/{id}.json";


        public VenuesClient(IRestClient client, IClientConfig config)
            : base(client, config)
        {
        }

        public Task<SearchVenuesResponse> SearchVenuesAsync(BaseQuery query)
        {
            var searchRequest = new RestRequest(VenuesPath, Method.GET) { RequestFormat = DataFormat.Json };
            return ExecuteRequestAsync<SearchVenuesResponse>(searchRequest, HttpStatusCode.OK, query);
        }

        public Task<IRestResponse> CallSearchVenuesAsync(BaseQuery query)
        {
            var searchRequest = new RestRequest(VenuesWithIdPath, Method.GET) { RequestFormat = DataFormat.Json };
            return ExecuteRequestAsync(searchRequest, query);
        }

        public Task<Venue> GetVenueDetailsAsync(Request request)
        {
            var searchRequest = new RestRequest(VenuesWithIdPath, Method.GET) { RequestFormat = DataFormat.Json };
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync<Venue>(searchRequest, HttpStatusCode.OK, request);
        }

        public Task<IRestResponse> CallGetVenueDetailsAsync(Request request)
        {
            var searchRequest = new RestRequest(VenuesWithIdPath, Method.GET) { RequestFormat = DataFormat.Json };
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync(searchRequest, request);
        }
    }
}
