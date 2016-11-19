
using NSubstitute;
using Ploeh.AutoFixture;
using RestSharp;
using System.Net;
using System.Threading.Tasks;
using TM.Discovery.V2;
using TM.Discovery.V2.Models;
using Xunit;

namespace TM.Discovery.Tests.V2.ClientTests
{
    public class GetVenueDetailsMethodTests : MethodTest
    {
        private readonly VenuesClient _sut;
        private readonly Venue _venue;

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

        [Fact]
        public async Task GetVenueDetailsAsync_ShouldReturnClassification()
        {
            var result = await _sut.GetVenueDetailsAsync(new GetRequest(""));
            Assert.Equal(_venue, result);
        }

        [Fact]
        public async Task CallGetVenueDetailsAsync_ShouldReturnIRestResponse()
        {
            var result = await _sut.CallGetVenueDetailsAsync(new GetRequest(""));
            Assert.NotNull(result);
            Assert.IsType<RestResponse>(result);
            Assert.Equal(_venue.ToString(), result.Content);
        }
    }
}
