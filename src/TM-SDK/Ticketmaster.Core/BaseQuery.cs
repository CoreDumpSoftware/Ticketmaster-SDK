namespace Ticketmaster.Core
{
    using System.Collections.Generic;

    public abstract class BaseQuery<T> : IApiRequest
    {
        /// <summary>
        ///     The parameters dictionary
        /// </summary>
        protected Dictionary<string, string> ParametersDictionary;

        protected BaseQuery()
        {
            ParametersDictionary = new Dictionary<string, string>();
        }

        /// <summary>
        ///     Gets or sets the query parameters.
        /// </summary>
        /// <value>
        ///     The query parameters.
        /// </value>
        public IEnumerable<KeyValuePair<string, string>> QueryParameters => ParametersDictionary;

        /// <summary>
        ///     Adds the query parameter.
        /// </summary>
        /// <param name="parameter">The Key Value Pair parameter.</param>
        public abstract void AddQueryParameter(KeyValuePair<T, string> parameter);
    }
}