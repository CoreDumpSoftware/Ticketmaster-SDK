namespace Ticketmaster.Discovery.V2.Models
{
    using System.Collections.Generic;
    using Core;

    public class SearchClassificationsRequest : BaseQuery<QueryParameters>
    {
        public override void AddQueryParameter(KeyValuePair<QueryParameters, string> parameter)
        {
            ParametersDictionary.Add(parameter.Key.ToString(), parameter.Value);
        }
    }
}