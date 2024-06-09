namespace ConsumingAPIs.Models
{
    public class FishApi
    {
        public int id { get; set; }
        public string name { get; set; }   
        public string url { get; set; }
        public FishMetaApi  meta { get; set; }

    }
}
