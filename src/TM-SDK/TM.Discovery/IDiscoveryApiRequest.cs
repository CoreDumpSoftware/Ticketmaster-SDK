namespace Ticketmaster.Discovery
{
    using System.Collections.Generic;

    public interface IDiscoveryApiRequest
    {
        IEnumerable<KeyValuePair<string, string>> QueryParameters { get; }
    }
}