using System.Collections.Generic;

namespace TM.Discovery.V2.Models
{
    public class SearchEventsRequest : BaseQuery<SearchEventsQueryParameters>
    {
        public override void AddQueryParameter(KeyValuePair<SearchEventsQueryParameters, string> parameter)
        {
            ParametersDictionary.Add(parameter.Key.ToString(), parameter.Value);
        }
    }
}
