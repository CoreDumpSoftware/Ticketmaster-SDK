namespace Ticketmaster.Discovery.V2.Models
{
    using Core;

    public class SearchAttractionsRequest : BaseQuery<SearchAttractionsRequest, QueryParameters>
    {
        public override SearchAttractionsRequest AddQueryParameter(QueryParameters parameter, string value)
        {
            ParametersDictionary.Add(parameter.ToString(), value);
            return this;
        }
    }
}