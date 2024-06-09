namespace ConsumingAPIs.Models
{
    public class FishMetaApi
    {
        public string conservation_status { get; set; }
        public FishClassificationApi scientific_classification { get; set; }

        public string binomial_name { get; set; }  
    }
}
