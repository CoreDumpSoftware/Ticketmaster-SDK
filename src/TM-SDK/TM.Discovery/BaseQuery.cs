using System.Collections.Generic;

namespace TM.Discovery
{
    public class BaseQuery
    {
        public BaseQuery()
        {
            QueryParameters = new Dictionary<string, string>();
        }

        /// <summary>
        /// Gets or sets the query parameters.
        /// </summary>
        /// <value>
        /// The query parameters.
        /// </value>
        public Dictionary<string, string> QueryParameters { get; protected set; }
    }
}
