using System.Diagnostics;

namespace MVC_with_EF.Models
{
    public class EnrollmentViewModel
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grades? Grade { get; set; }

        public virtual CourseViewModel Course { get; set; }
        public virtual StudentViewModel Student { get; set; }
    }

}
