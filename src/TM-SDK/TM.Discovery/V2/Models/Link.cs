
namespace TM.Discovery.V2.Models
{
    /// <summary>
    /// The Link class.
    /// </summary>
    public class Link
    {
        /// <summary>
        /// Gets or sets the href.
        /// </summary>
        /// <value>
        /// The href.
        /// </value>
        public virtual string Href { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Link"/> is templated.
        /// </summary>
        /// <value>
        ///   <c>true</c> if templated; otherwise, <c>false</c>.
        /// </value>
        public virtual bool Templated { get; set; }
    }
}
