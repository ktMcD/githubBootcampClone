using System.ComponentModel;

namespace MyWebApp.Models
{
    public class CourseViewModel
    {
        public int Id { get; set; }

        [DisplayName("Course Name")]
        public string Name { get; set; }

        [DisplayName(" Course Description")]
        public string Description { get; set; }

        [DisplayName("Maximum Students Allowed")]
        public int MaxStudentCount { get; set; }

        [DisplayName("Current Students Enrolled")]
        public int CurrentStudents { get; set; }
    }

}
