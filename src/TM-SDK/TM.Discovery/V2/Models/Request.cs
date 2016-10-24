namespace TM.Discovery.V2.Models
{
    public class Request : BaseQuery
    {
        public Request(string id)
        {
            Id = id;
        }

        public string Id { get; set; }
    }
}
