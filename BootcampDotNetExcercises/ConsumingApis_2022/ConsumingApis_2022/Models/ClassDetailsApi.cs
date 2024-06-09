namespace ConsumingApis_2022.Models
{
    public class ClassDetailsApi
    {
        public string index { get; set; }
        public string name { get; set; }
        public int hit_die { get; set; }
        public List<InventoryApi> starting_equipment { get; set; }
        public string url { get; set; }
    }

}
