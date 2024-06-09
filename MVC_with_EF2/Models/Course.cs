using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_with_EF2.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Style { get; set; }
        public int Rating { get; set; }
    }
}
