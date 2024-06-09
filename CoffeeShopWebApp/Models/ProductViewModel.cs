using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CoffeeShopWebApp.Models
{
    public class ProductViewModel
    {
        [DisplayName("Product ID")]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        [DisplayName("Product Name")]
        public string? Name { get; set; }

        [MaxLength(50)]
        [DisplayName("Product Description")]
        public string? Description { get; set; }

        [Required]
        [DisplayName("Product Price")]
        public double? Price { get; set; }

        [DisplayName("Product Category")]
        public string? Category { get; set; }
    }
}
