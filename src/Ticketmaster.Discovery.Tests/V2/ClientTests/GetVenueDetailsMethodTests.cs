namespace Ticketmaster.Discovery.Tests.V2.ClientTests
{
    using System.Net;
    using System.Threading.Tasks;
    using AutoFixture;
    using Core;
    using Discovery.V2;
    using Discovery.V2.Models;
    using NSubstitute;
    using RestSharp;
    using Xunit;

    public class GetVenueDetailsMethodTests : MethodTest
    {
        public GetVenueDetailsMethodTests()
        {
            _venue = Fixture.Create<Venue>();
            Client
                .ExecuteTaskAsync<Venue>(Arg.Any<IRestRequest>())
                .Returns(new RestResponse<Venue>
                {
                    Data = _venue,
                    StatusCode = HttpStatusCode.OK
                });
            Client
                .ExecuteTaskAsync(Arg.Any<IRestRequest>())
                .Returns(new RestResponse
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = _venue.ToString()
                });
            _sut = new VenuesClient(Client, Config);
        }

        private readonly VenuesClient _sut;
        private readonly Venue _venue;

        [Fact]
        public async Task CallGetVenueDetailsAsync_ShouldReturnIRestResponse()
        {
            var result = await _sut.CallGetVenueDetailsAsync(new GetRequest(""));
            Assert.NotNull(result);
            Assert.IsType<RestResponse>(result);
            Assert.Equal(_venue.ToString(), result.Content);
        }

        [Fact]
        public async Task GetVenueDetailsAsync_ShouldReturnClassification()
        {
            var result = await _sut.GetVenueDetailsAsync(new GetRequest(""));
            Assert.Equal(_venue, result);
        }
    }
}