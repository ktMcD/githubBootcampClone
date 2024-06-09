using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_with_EF.Models
{
    public class CourseViewModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual List<EnrollmentViewModel> Enrollments { get; set; }
    }

}
