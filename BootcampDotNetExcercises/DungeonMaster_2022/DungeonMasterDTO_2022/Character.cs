namespace DungeonMasterDTO_2022
{
    public class Character
    {
        public int Id { get; set; }
        public string CharacterName { get; set; }        
        public int CurrentLevel { get; set; }        
        public int HitPoint { get; set; }
        public string? BackStory { get; set; }
        public int? CharacterRaceId { get; set; }
        public virtual CharacterRace CharacterRace { get; set; }
        public int? CharacterClassId { get; set; }
        public virtual CharacterClass CharacterClass { get; set; }

        public virtual List<CharacterItemRelationship> Relationships { get; set; } = new List<CharacterItemRelationship>();

    }
}
