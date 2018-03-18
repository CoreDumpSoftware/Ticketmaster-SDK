using System.Collections.Generic;

namespace Ticketmaster.Commerce.V2.Models
{
    public class DataCollection<TClass>
        where TClass : class
    {
        public DataCollection()
        {
            Data = new List<TClass>();
        }

        public IEnumerable<TClass> Data { get; set; }
    }
}
