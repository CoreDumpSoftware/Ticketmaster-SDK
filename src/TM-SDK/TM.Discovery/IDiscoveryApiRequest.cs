using System.Collections.Generic;

namespace TM.Discovery
{
    public interface IDiscoveryApiRequest
    {
        IEnumerable<KeyValuePair<string, string>> QueryParameters { get; }
    }
}
