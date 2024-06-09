using DungeonMasterRespository_2022;
using DungeonMasterDTO_2022;

namespace DungeonMasterDomain_2022
{
    public class DungeonNpcInteractor
    {
        private DungeonNpcRepository _repository;

        public DungeonNpcInteractor()
        {
            _repository = new DungeonNpcRepository();
        }
    }
}
