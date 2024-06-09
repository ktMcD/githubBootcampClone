using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_with_EF2.DataAccessLayer;
using MVC_with_EF2.Models;
using System.Collections.Generic;
using System.Drawing;

namespace MVC_with_EF2.Controllers
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
            Student student = db.Students
                .Where(x => x.ID == id)
                .Include(i => i.Enrollments) // <<<<<-------- pay attention to this use it if you want to use a foreign key
                .FirstOrDefault();

            if (student == null)
            {
                throw new BadHttpRequestException("Id not found");
            }

            for (int i = 0; i < student.Enrollments.Count; i++)
            {
                student.Enrollments[i].Course = db.Courses.FirstOrDefault(x => x.CourseID == student.Enrollments[i].CourseID);
            }

            return View(student); // this is the name of the controller and its matching view folder
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateJelly(IFormCollection collection)
        {
            try
            {
                Student newStudent = new Student()
                {
                    LastName = collection["LastName"],
                    FirstMidName = collection["FirstMidName"],
                    EnrollmentDate = DateTime.Parse(collection["EnrollmentDate"])
                };
                AddStudent(newStudent);
                newStudent.ID = db.Students.Max(x => x.ID) + 1;
                db.Students.Add(newStudent);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));

            }

            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                return View();
            }

        }
        private void AddStudent(Student studentToAdd)
        {
            db.Students.Add(studentToAdd);
            db.SaveChanges();
        }

    }
}
