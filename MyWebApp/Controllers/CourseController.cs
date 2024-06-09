using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    public class CourseController : Controller
    {
        List<CourseViewModel> _courses;

        public CourseController()
        {
            _courses = new List<CourseViewModel>();
            CourseViewModel courseOne = new CourseViewModel()
            {
                Id = 1,
                Name = "C#",
                Description = "The best language",
                MaxStudentCount = 12,
                CurrentStudents = 25
            };
            CourseViewModel courseTwo = new CourseViewModel()
            {
                Id = 2,
                Name = "Java",
                Description = "The best language",
                MaxStudentCount = 12,
                CurrentStudents = 10
            };
            _courses.Add(courseOne);
            _courses.Add(courseTwo);
        }

        // GET: CourseController
        public ActionResult List()
        {
            return View(_courses);
        }

        // GET: CourseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CourseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CourseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
