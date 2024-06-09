namespace DungeonMasterDTO_2022
{
    public class CharacterRace
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Character> Characters { get; set; } = new List<Character>();

    }
}
