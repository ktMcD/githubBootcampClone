using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    public class StudentController : Controller
    {
        StudentRepository repo;
        public StudentController()
        {
            repo = new StudentRepository(); 
        }
        // GET: StudentController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View(repo.GetMockStudents());
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            StudentViewModel student = repo.GetMockStudents().FirstOrDefault(x => x.Id == id);
            return View(student);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                StudentViewModel newStudent = new StudentViewModel()
                {
                    Name = collection["Name"],
                    Course = collection["Course"],
                    TechnicalExperience = collection["TechnicalExperience"],
                    PreviousCourseCount = int.Parse(collection["PreviousCourseCount"])
                };

                repo.CreateStudent(newStudent);
                return RedirectToAction(nameof(List));
            }

            catch
            {
                return View();
            }

        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            StudentViewModel student = repo.GetMockStudents().FirstOrDefault(x => x.Id == id);
            return View(student);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                StudentViewModel updatedStudent = new StudentViewModel()
                {
                    Id = int.Parse(collection["Id"]),
                    Name = collection["Name"],
                    Course = collection["Course"],
                    TechnicalExperience = collection["TechnicalExperience"],
                    PreviousCourseCount = int.Parse(collection["PreviousCourseCount"])
                };
                repo.UpdateStudent(updatedStudent);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            StudentViewModel student = repo.GetMockStudents().FirstOrDefault(x => x.Id == id);
            return View(student);
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                repo.DeleteStudent(id);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }
    }
}
