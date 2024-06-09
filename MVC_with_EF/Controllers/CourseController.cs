using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_with_EF.DataAccessLayer;
using MVC_with_EF.Models;

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
            CourseViewModel course = db.Courses
                .Where(x => x.CourseID == id)
                .Include(i => i.Enrollments)
                .FirstOrDefault();

            for (int i = 0; i < course.Enrollments.Count; i++)
            {
                course.Enrollments[i].Student = db.Students.FirstOrDefault(x => x.Id == course.Enrollments[i].StudentID);
            }

            if (course == null)
            {
                throw new BadHttpRequestException("Id not found");
            }
            return View(course);
        }

    }
}
