
using RestSharp;
using System.Net;
using System.Threading.Tasks;
using TM.Discovery.V2.Models;

namespace TM.Discovery.V2
{
    public class EventsClient : BaseClient, IEventsClient
    {
        public const string EventsPath = "/v2/events.json";
        public const string EventsPathWithId = "/v2/events/{id}.json";
        public const string EventsImagesPath = "/v2/events/{id}/images.json";

        public EventsClient(IRestClient client, IClientConfig config)
            : base(client, config)
        {
        }

        public async Task<SearchEventsResponse> SearchEventsAsync(BaseQuery request)
        {
            var searchRequest = new RestRequest(EventsPath, Method.GET) { RequestFormat = DataFormat.Json };
            return await ExecuteRequestAsync<SearchEventsResponse>(searchRequest, HttpStatusCode.OK, request);
        }

        public async Task<IRestResponse> CallSearchEventsAsync(BaseQuery request)
        {
            var searchRequest = new RestRequest(EventsPath, Method.GET) { RequestFormat = DataFormat.Json };
            return await ExecuteRequestAsync(searchRequest, request);
        }

        public async Task<Event> GetEventDetailsAsync(Request request)
        {
            var searchRequest = new RestRequest(EventsPathWithId, Method.GET) { RequestFormat = DataFormat.Json };
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return await ExecuteRequestAsync<Event>(searchRequest, HttpStatusCode.OK, request);
        }

        public Task<IRestResponse> CallGetEventDetailsAsync(Request request)
        {
            var searchRequest = new RestRequest(EventsPathWithId, Method.GET) { RequestFormat = DataFormat.Json };
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync(searchRequest, request);
        }

        public Task<GetEventImagesResponse> GetEventImagesAsync(Request request)
        {
            var searchRequest = new RestRequest(EventsImagesPath, Method.GET) { RequestFormat = DataFormat.Json };
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync<GetEventImagesResponse>(searchRequest, HttpStatusCode.OK, request);
        }

        public Task<IRestResponse> CallGetEventImagesAsync(Request request)
        {
            var searchRequest = new RestRequest(EventsImagesPath, Method.GET) { RequestFormat = DataFormat.Json };
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync(searchRequest, request);
        }
    }
}
