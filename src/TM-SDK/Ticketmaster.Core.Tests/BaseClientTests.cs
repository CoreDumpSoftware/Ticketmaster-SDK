namespace Ticketmaster.Core.Tests
{
    using System.IO;
    using System.Net;
    using System.Threading.Tasks;
    using AutoFixture;
    using NSubstitute;
    using RestSharp;
    using Xunit;

    public class BaseClientImplimintation : BaseClient
    {
        public BaseClientImplimintation(IRestClient client, IClientConfig config)
            : base(client, config)
        {

        }

        public Task<IApiRespond> Execute(IRestRequest request, HttpStatusCode code)
        {
            return ExecuteRequestAsync<IApiRespond>(request, code);
        }
    }

    public class BaseClientTests
    {
        private const string EventsPath = "/v2/events.json";
        private readonly IRestClient _client;
        private readonly IClientConfig _config;
        private readonly Fixture _fixture;
        private readonly BaseClientImplimintation _sut;

        public BaseClientTests()
        {
            _fixture = new Fixture();
            _config = Substitute.For<IClientConfig>();
            _config.ConsumerKey.Returns("K1uJLzJ5mdt3oBKNSzjcEEEzxHuJJXiX-1");
            _config.ApiRootUrl.Returns("https://app.ticketmaster.com/discovery/");
            _client = Substitute.For<IRestClient>();
            _sut = new BaseClientImplimintation(_client, _config);
        }

        [Fact]
        public async Task ExecuteRequestAsync_ShouldValidateResponse()
        {
            _client
                .ExecuteTaskAsync<IApiRespond>(Arg.Any<IRestRequest>())
                .Returns(new RestResponse<IApiRespond>
                {
                    StatusCode = HttpStatusCode.Unauthorized,
                    Content = "{ \"fault\": { \"faultstring\": \"Invalid ApiKey\", \"detail\": { \"errorcode\": \"oauth.v2.InvalidApiKey\" } } }"
                });


            var searchRequest = new RestRequest(EventsPath, Method.GET) { RequestFormat = DataFormat.Json };
            await Assert.ThrowsAnyAsync<InvalidDataException>(() => _sut.Execute(searchRequest, HttpStatusCode.OK));
        }
    }
}
