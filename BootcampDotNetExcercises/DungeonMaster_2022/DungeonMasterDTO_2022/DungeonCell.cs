namespace DungeonMasterDTO_2022
{
    public class DungeonCell
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int NumberOfEnemies { get; set; }
        public bool ContainsBossMonster { get; set; }
        public bool ContainsTrap { get; set; }
        public string? Description { get; set; }
        
    }
}
