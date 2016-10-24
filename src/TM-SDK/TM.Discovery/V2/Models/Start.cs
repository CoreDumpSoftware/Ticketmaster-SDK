using System;

namespace TM.Discovery.V2.Models
{
    /// <summary>
    /// The Start dates class.
    /// </summary>
    public class Start
    {
        /// <summary>
        /// Gets or sets the local date as string.
        /// </summary>
        /// <value>
        /// The local date.
        /// </value>
        public string LocalDate { get; set; }


        /// <summary>
        /// Gets or sets the local time as string.
        /// </summary>
        /// <value>
        /// The local time.
        /// </value>
        public string LocalTime { get; set; }

        /// <summary>
        /// Gets or sets the date time.
        /// </summary>
        /// <value>
        /// The date time.
        /// </value>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [date TBD].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [date TBD]; otherwise, <c>false</c>.
        /// </value>
        public bool DateTbd { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [date tba].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [date tba]; otherwise, <c>false</c>.
        /// </value>
        public bool DateTba { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [time tba].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [time tba]; otherwise, <c>false</c>.
        /// </value>
        public bool TimeTba { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [no specific time].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [no specific time]; otherwise, <c>false</c>.
        /// </value>
        public bool NoSpecificTime { get; set; }
    }
}
