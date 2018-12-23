namespace Ticketmaster.Discovery.V2.Models
{
    using Core;

    public class SearchVenuesRequest : BaseQuery<SearchVenuesRequest, SearchVenuesQueryParameters>
    {
        public override SearchVenuesRequest AddQueryParameter(SearchVenuesQueryParameters parameter, string value)
        {
            Parameters.Add(parameter.ToString(), value);
            return this;
        }
    }
}