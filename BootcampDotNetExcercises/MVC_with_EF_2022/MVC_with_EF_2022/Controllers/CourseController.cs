using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_with_EF_2022.DataAccessLayer;
using MVC_with_EF_2022.Models;

namespace MVC_with_EF_2022.Controllers
{
    public class CourseController : Controller
    {
        private SchoolContext db = new SchoolContext();

        public IActionResult Index()
        {
            return View(db.Courses.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                throw new BadHttpRequestException("No Id Provided");
            }

            Course course = db.Courses
                .Where(x => x.CourseID == id)
                .Include(i => i.Enrollments)
                .FirstOrDefault();                     

            if (course == null)
            {
                throw new BadHttpRequestException("Course not found");
            }

            // Looping through the Enrollment data (all ids), populating the Student data using the ID
            for (int i = 0; i < course.Enrollments.Count; i++)
            {
                course.Enrollments[i].Student = db.Students.FirstOrDefault(x => x.ID == course.Enrollments[i].StudentID);
            }

            return View(course);
        }


    }
}
