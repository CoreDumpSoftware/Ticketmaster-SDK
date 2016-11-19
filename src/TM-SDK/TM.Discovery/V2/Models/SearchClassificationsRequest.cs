using System.Collections.Generic;

namespace TM.Discovery.V2.Models
{
    public class SearchClassificationsRequest : BaseQuery<QueryParameters>
    {
        public override void AddQueryParameter(KeyValuePair<QueryParameters, string> parameter)
        {
            ParametersDictionary.Add(parameter.Key.ToString(), parameter.Value);
        }
    }
}
