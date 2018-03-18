namespace Ticketmaster.Commerce.V2
{
    using Core;
    using Models;
    using RestSharp;
    using System.Net;
    using System.Threading.Tasks;

    public class EventOffersClient : BaseClient, IEventOffersClient
    {
        private const string EventOffersPath = @"/v2/events/{id}/offers.json";

        public EventOffersClient(IRestClient client, IClientConfig config)
            : base(client, config)
        {
        }

        public Task<EventOffers> GetEventOffersAsync(GetRequest getRequest)
        {
            return GetEventOffersAsync((IApiGetRequest)getRequest);
        }

        public Task<IRestResponse> CallGetEventOffersAsync(GetRequest getRequest)
        {
            return CallGetEventOffersAsync((IApiGetRequest)getRequest);
        }

        public Task<EventOffers> GetEventOffersAsync(IApiGetRequest getRequest)
        {
            var searchRequest =
                new RestRequest(EventOffersPath, Method.GET) { RequestFormat = DataFormat.Json };
            searchRequest.AddParameter("id", getRequest.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync<EventOffers>(searchRequest, HttpStatusCode.OK, getRequest);
        }

        public Task<IRestResponse> CallGetEventOffersAsync(IApiGetRequest getRequest)
        {
            var searchRequest =
                new RestRequest(EventOffersPath, Method.GET) { RequestFormat = DataFormat.Json };
            searchRequest.AddParameter("id", getRequest.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync(searchRequest, getRequest);
        }
    }
}
