namespace Ticketmaster.Discovery.V2
{
    using System.Net;
    using System.Threading.Tasks;
    using Models;
    using RestSharp;

    public class EventsClient : BaseClient, IEventsClient
    {
        public const string EventsPath = "/v2/events.json";
        public const string EventsPathWithId = "/v2/events/{id}.json";
        public const string EventsImagesPath = "/v2/events/{id}/images.json";

        public EventsClient(IRestClient client, IClientConfig config)
            : base(client, config)
        {
        }

        public Task<SearchEventsResponse> SearchEventsAsync(SearchEventsRequest request)
        {
            return SearchEventsAsync((IDiscoveryApiRequest) request);
        }

        public Task<SearchEventsResponse> SearchEventsAsync(IDiscoveryApiRequest request)
        {
            var searchRequest = new RestRequest(EventsPath, Method.GET) {RequestFormat = DataFormat.Json};
            return ExecuteRequestAsync<SearchEventsResponse>(searchRequest, HttpStatusCode.OK, request);
        }

        public Task<IRestResponse> CallSearchEventsAsync(SearchEventsRequest request)
        {
            return CallSearchEventsAsync((IDiscoveryApiRequest) request);
        }

        public Task<IRestResponse> CallSearchEventsAsync(IDiscoveryApiRequest request)
        {
            var searchRequest = new RestRequest(EventsPath, Method.GET) {RequestFormat = DataFormat.Json};
            return ExecuteRequestAsync(searchRequest, request);
        }

        public Task<Event> GetEventDetailsAsync(GetRequest request)
        {
            return GetEventDetailsAsync((IDiscoveryApiGetRequest) request);
        }

        public Task<Event> GetEventDetailsAsync(IDiscoveryApiGetRequest request)
        {
            var searchRequest = new RestRequest(EventsPathWithId, Method.GET) {RequestFormat = DataFormat.Json};
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync<Event>(searchRequest, HttpStatusCode.OK, request);
        }

        public Task<IRestResponse> CallGetEventDetailsAsync(GetRequest request)
        {
            return CallGetEventDetailsAsync((IDiscoveryApiGetRequest) request);
        }

        public Task<IRestResponse> CallGetEventDetailsAsync(IDiscoveryApiGetRequest request)
        {
            var searchRequest = new RestRequest(EventsPathWithId, Method.GET) {RequestFormat = DataFormat.Json};
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync(searchRequest, request);
        }

        public Task<GetEventImagesResponse> GetEventImagesAsync(GetRequest request)
        {
            return GetEventImagesAsync((IDiscoveryApiGetRequest) request);
        }

        public Task<GetEventImagesResponse> GetEventImagesAsync(IDiscoveryApiGetRequest request)
        {
            var searchRequest = new RestRequest(EventsImagesPath, Method.GET) {RequestFormat = DataFormat.Json};
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync<GetEventImagesResponse>(searchRequest, HttpStatusCode.OK, request);
        }

        public Task<IRestResponse> CallGetEventImagesAsync(GetRequest request)
        {
            return CallGetEventImagesAsync((IDiscoveryApiGetRequest) request);
        }

        public Task<IRestResponse> CallGetEventImagesAsync(IDiscoveryApiGetRequest request)
        {
            var searchRequest = new RestRequest(EventsImagesPath, Method.GET) {RequestFormat = DataFormat.Json};
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync(searchRequest, request);
        }
    }
}