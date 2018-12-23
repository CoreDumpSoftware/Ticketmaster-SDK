namespace Ticketmaster.Core
{
    public class GetRequest : BaseQuery<GetRequest, string>, IApiGetRequest
    {
        public GetRequest(string id)
        {
            Id = id;
        }

        public string Id { get; set; }

        public override GetRequest AddQueryParameter(string parameterName, string value)
        {
            Parameters.Add(parameterName, value);
            return this;
        }
    }
}