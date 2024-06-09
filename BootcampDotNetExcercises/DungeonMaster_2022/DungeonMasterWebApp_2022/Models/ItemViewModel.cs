using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DungeonMasterDTO_2022;

namespace DungeonMasterWebApp_2022.Models
{
    public class ItemViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        public int? AttackModifier { get; set; }
        public int? DefenseModifier { get; set; }
        public string? Lore { get; set; }

        [DisplayName("Is Item Enchanted")]
        public bool IsEnchanted { get; set; } = false;

        [DisplayName("Is Item Breakable")]
        public bool IsBreakable { get; set; } = true;

        public static ItemViewModel ViewModelMapper(Item itemDTO)
        {
            return new ItemViewModel
            {
                Id = itemDTO.Id,
                Name = itemDTO.Name,
                Description = itemDTO.Description,
                AttackModifier = itemDTO.AttackModifier,
                DefenseModifier = itemDTO.DefenseModifier,
                Lore = itemDTO.Lore,
                // ternary statement
                IsEnchanted = itemDTO.IsEnchanted == null ? false : (bool)itemDTO.IsEnchanted,
                IsBreakable = itemDTO.IsBreakable == null ? false : (bool)itemDTO.IsBreakable
            };
        }

        public static Item ItemDtoMapperForUpdate(IFormCollection collection)
        {
            return new Item
            {
                Id = int.Parse(collection["Id"]),
                Name = collection["Name"],
                Description = collection["Description"],
                Lore = collection["Lore"],
                AttackModifier = int.Parse(collection["AttackModifier"]),
                DefenseModifier = int.Parse(collection["DefenseModifier"]),
                // If checkbox is empty Collection returns "false"
                // If checkbox is checked Collection returns "true,false"
                IsBreakable = collection["IsBreakable"].Contains("true"),
                IsEnchanted = collection["IsEnchanted"].Contains("true")
            };
        }

        public static Item ItemDtoMapperForCreate(IFormCollection collection)
        {
            return new Item
            {
                Name = collection["Name"],
                Description = collection["Description"],
                Lore = collection["Lore"],
                AttackModifier = int.Parse(collection["AttackModifier"]),
                DefenseModifier = int.Parse(collection["DefenseModifier"]),
                IsBreakable = collection["IsBreakable"].Contains("true"),
                IsEnchanted = collection["IsEnchanted"].Contains("true")
            };
        }
    }




}
