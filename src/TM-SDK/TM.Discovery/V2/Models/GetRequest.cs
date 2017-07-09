namespace Ticketmaster.Discovery.V2.Models
{
    using System.Collections.Generic;

    public class GetRequest : BaseQuery<string>, IDiscoveryApiGetRequest
    {
        public GetRequest(string id)
        {
            Id = id;
        }

        public string Id { get; set; }

        public override void AddQueryParameter(KeyValuePair<string, string> parameter)
        {
            ParametersDictionary.Add(parameter.Key, parameter.Value);
        }
    }
}