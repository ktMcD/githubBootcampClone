namespace ConsumingAPIs.Models
{
    public class MovieApi
    {
        public int rank { get; set; }
        public string title { get; set; }
        public string thumbnail { get; set; }
        public string rating { get; set; }
        public string id { get; set; }
        public int year { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public string trailer { get; set; }
        public List<string> genre { get; set; }
        public List<string> director { get; set; }
        public List<string> writers { get; set; }
        public string imdbid { get; set; }

    }
}
