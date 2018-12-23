namespace Ticketmaster.Discovery.V2.Models
{
    using Core;
    using Core.V2.Models;

    public class SearchClassificationsRequest : BaseQuery<SearchClassificationsRequest, QueryParameters>
    {
        public override SearchClassificationsRequest AddQueryParameter(QueryParameters parameter, string value)
        {
            Parameters.Add(parameter.ToString(), value);
            return this;
        }
    }
}