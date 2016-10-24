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

        public Task<SearchClassificationsResponse> SearchClassificationsAsync(BaseQuery request)
        {
            var searchRequest = new RestRequest(ClassificationsPath, Method.GET) { RequestFormat = DataFormat.Json };
            return ExecuteRequestAsync<SearchClassificationsResponse>(searchRequest, HttpStatusCode.OK, request);
        }

        public Task<IRestResponse> CallSearchClassificationsAsync(BaseQuery request)
        {
            var searchRequest = new RestRequest(ClassificationsPath, Method.GET) { RequestFormat = DataFormat.Json };
            return ExecuteRequestAsync(searchRequest, request);
        }

        public Task<Classification> GetClassificationDetailsAsync(Request request)
        {
            var searchRequest = new RestRequest(ClassificationsPathWithId, Method.GET) { RequestFormat = DataFormat.Json };
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync<Classification>(searchRequest, HttpStatusCode.OK, request);
        }

        public Task<IRestResponse> CallGetClassificationDetailsAsync(Request request)
        {
            var searchRequest = new RestRequest(ClassificationsPathWithId, Method.GET) { RequestFormat = DataFormat.Json };
            searchRequest.AddParameter("id", request.Id, ParameterType.UrlSegment);
            return ExecuteRequestAsync(searchRequest, request);
        }
    }
}
