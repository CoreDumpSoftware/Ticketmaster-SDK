namespace Ticketmaster.Discovery.V2.Models
{
    using System.Collections.Generic;

    public class SearchEventsRequest : BaseQuery<SearchEventsQueryParameters>
    {
        public override void AddQueryParameter(KeyValuePair<SearchEventsQueryParameters, string> parameter)
        {
            ParametersDictionary.Add(parameter.Key.ToString(), parameter.Value);
        }
    }
}