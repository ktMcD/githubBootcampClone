namespace APIWithEF.Models
{
    public class Fish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Classification { get; set; }
        public bool Freshwater { get; set; }
        public bool Saltwater { get; set; }
    }
}
