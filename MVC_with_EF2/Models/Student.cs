namespace MVC_with_EF2.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public virtual List<Enrollment> Enrollments { get; set; }

    }
}
