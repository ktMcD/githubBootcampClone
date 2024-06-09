using Microsoft.AspNetCore.Mvc;
using MVC_with_EF2.Models;
using MVC_with_EF2.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

namespace MVC_with_EF2.Controllers

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
                throw new BadHttpRequestException("Course not found for that Id");
            }

            // Looping through the Enrollment data (all ids), populating the Student data using the ID
            // we have to do a for here because a foreach doesn't allow data updates
            for (int i = 0; i < course.Enrollments.Count; i++)
            {
                course.Enrollments[i].Student = db.Students.FirstOrDefault(x => x.ID == course.Enrollments[i].StudentID);
            }
            return View(course);
        }

    }
}
