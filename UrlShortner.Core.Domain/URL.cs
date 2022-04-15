namespace UrlShortner.Core.Domain
{
    public class URL
    {
        public long Id { get; init; }
        public string ShortPath { get; init; } 
        public string LongPath { get; init; } 

        public DateTime CreatedDate { get; init; }
    }
}