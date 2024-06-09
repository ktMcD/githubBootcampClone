using Microsoft.AspNetCore.Mvc;
using MVC_with_EF.DataAccessLayer;
using MVC_with_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace MVC_with_EF_2022.Controllers
{
    public class StudentController : Controller
    {
        private SchoolContext db = new SchoolContext();


        public IActionResult Index()
        {
            return View(db.Students.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                throw new BadHttpRequestException("No Id Provided");
            }
            StudentViewModel student = db.Students
                .Where(x => x.Id == id)
                .Include(i => i.Enrollments)
                .FirstOrDefault();

            if (student == null)
            {
                throw new BadHttpRequestException("Id not found");
            }

            for (int i = 0; i < student.Enrollments.Count; i++)
            {
                student.Enrollments[i].Course = db.Courses.FirstOrDefault(x => x.CourseID == student.Enrollments[i].CourseID);
            }


            return View(student);
        }

    }
}
