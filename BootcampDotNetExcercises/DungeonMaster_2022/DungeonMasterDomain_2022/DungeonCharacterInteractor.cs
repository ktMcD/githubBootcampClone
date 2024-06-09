using DungeonMasterRespository_2022;
using DungeonMasterDTO_2022;

namespace DungeonMasterDomain_2022
{
    public class DungeonCharacterInteractor
    {
        private DungeonCharacterRepository _repo;

        public DungeonCharacterInteractor()
        {
            _repo = new DungeonCharacterRepository();
        }

        public List<Character> GetAllCharacters()
        {
            return _repo.GetAllCharacters();
        }

        public List<Item> GetCharacterItems(List<CharacterItemRelationship> itemRelationships)
        {
            return _repo.GetCharacterItems(itemRelationships);
        }
    }
}
