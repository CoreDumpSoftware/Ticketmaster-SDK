namespace Ticketmaster.Core.V2.Models
{
    /// <summary>
    ///     The Image class model.
    /// </summary>
    public class Image
    {
        /// <summary>
        ///     Gets or sets the ratio.
        /// </summary>
        /// <value>
        ///     The ratio.
        /// </value>
        public string Ratio { get; set; }

        /// <summary>
        ///     Gets or sets the URL.
        /// </summary>
        /// <value>
        ///     The URL.
        /// </value>
        public string Url { get; set; }

        /// <summary>
        ///     Gets or sets the width.
        /// </summary>
        /// <value>
        ///     The width.
        /// </value>
        public int Width { get; set; }

        /// <summary>
        ///     Gets or sets the height.
        /// </summary>
        /// <value>
        ///     The height.
        /// </value>
        public int Height { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="Image" /> is fallback.
        /// </summary>
        /// <value>
        ///     <c>true</c> if fallback; otherwise, <c>false</c>.
        /// </value>
        public bool Fallback { get; set; }
    }
}