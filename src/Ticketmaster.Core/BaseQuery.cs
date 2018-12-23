namespace Ticketmaster.Core
{
    using System.Collections.Generic;

    public abstract class BaseQuery<TK, T> : IApiRequest
    {
        /// <summary>
        /// The parameters dictionary.
        /// </summary>
        protected Dictionary<string, string> Parameters;

        protected BaseQuery()
        {
            Parameters = new Dictionary<string, string>();
        }

        /// <summary>
        /// Gets the query parameters.
        /// </summary>
        /// <value>
        /// The query parameters.
        /// </value>
        public IEnumerable<KeyValuePair<string, string>> QueryParameters => Parameters;

        /// <summary>
        /// Adds the query parameter.
        /// </summary>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="value">The value of the parameter.</param>
        /// <returns>This class instance.</returns>
        public abstract TK AddQueryParameter(T parameterName, string value);
    }
}