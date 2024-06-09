using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using DungeonMasterDTO_2022;

namespace DungeonMasterRespository_2022
{
    public class DungeonCharacterRepository
    {
        private IConfigurationRoot _configuration;
        private DbContextOptionsBuilder<ApplicationDBContext> _optionsBuilder;

        public DungeonCharacterRepository()
        {
            BuildOptions();
        }
        private void BuildOptions()
        {
            _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
            _optionsBuilder = new DbContextOptionsBuilder<ApplicationDBContext>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DungeonManager"));
        }

        public List<Character> GetAllCharacters()
        {
            using (ApplicationDBContext db = new ApplicationDBContext(_optionsBuilder.Options))
            {
                return db.Characters.Include(x => x.CharacterRace).Include(x => x.CharacterClass).Include(x => x.Relationships).ToList();
            }
        }

        public List<Item> GetCharacterItems(List<CharacterItemRelationship> itemRelationships)
        {
            using (ApplicationDBContext db = new ApplicationDBContext(_optionsBuilder.Options))
            {
                return db.Items.Where(x => itemRelationships.Select(x => x.ItemId).Contains(x.Id)).ToList();
            }
        }

    }
}
