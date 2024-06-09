using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMasterDTO_2022
{
    public class Npc
    {
        public int Id { get; set; }
        public string NpcName { get; set; }
        public string? Backstory { get; set; }
        public bool IsFriendly { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Greeting { get; set; }
    }
}
