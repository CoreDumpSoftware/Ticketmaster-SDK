namespace Ticketmaster.IntegrationTests.V2
{
    using ApprovalTests;
    using ApprovalTests.Reporters;
    using Core;
    using Discovery.V2;
    using Discovery.V2.Models;
    using RestSharp;
    using Xunit;

    public class EventsClientIntegrationTests : ClientBaseTest
    {
        private readonly EventsClient _sut;

        public EventsClientIntegrationTests()
        {
            _sut = new EventsClient(Client, Config);
        }

        [Fact(Skip = "Ticketmaster.Discovery.API returns for same request different data each time.")]
        [UseReporter(typeof(DiffReporter))]
        public void SearchEventsAsync_ShouldReturnSearchEventsRequest()
        {
            var request = new SearchEventsRequest();

            var searchEventsResponse = _sut.SearchEventsAsync(request).Result;
            Assert.NotNull(searchEventsResponse);
            Assert.IsType<SearchEventsResponse>(searchEventsResponse);
            Assert.IsAssignableFrom<IApiResponse>(searchEventsResponse);

            var iApiResponse = _sut.CallSearchEventsAsync(request).Result;
            Assert.NotNull(iApiResponse);
            Assert.IsAssignableFrom<IRestResponse>(iApiResponse);

            var jobject = SimpleJson.SimpleJson.SerializeObject(searchEventsResponse);
            Approvals.VerifyJson(jobject);
        }
    }
}
