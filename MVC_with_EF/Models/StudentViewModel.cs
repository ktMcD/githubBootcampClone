using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_with_EF.Models
{
    public class StudentViewModel
    {
        [DisplayName("Student ID")]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Student Name")]
        public string? Name { get; set; }

        [MaxLength(20)]
        [DisplayName("Current Course")]
        public string? Course { get; set; }

        [DisplayName("Technical Experience")]
        public string? TechnicalExperience { get; set; }

        [Range(0, 20)]
        [DisplayName("Previous Course Count")]
        public int? PreviousCourseCount { get; set; }

        public virtual List<EnrollmentViewModel> Enrollments { get; set; }

    }
}
