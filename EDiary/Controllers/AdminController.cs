using Microsoft.AspNetCore.Mvc;

namespace EDiary.Controllers
{
    public class AdminController : Controller

    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult AddStudent()
        {
            return PartialView("~/Views/Admin/_addStudent.cshtml");
        }

        public IActionResult AddTeacher()
        {
            return PartialView("~/Views/Admin/_addTeacher.cshtml");
        }

        public IActionResult AddSubject()
        {
            return PartialView("~/Views/Admin/_addSubject.cshtml");
        }

        public IActionResult ShowStudents()
        {
            return PartialView("~/Views/Admin/_tableStudent.cshtml");
        }

        public IActionResult ShowTeachers()
        {
            return PartialView("~/Views/Admin/_tableTeacher.cshtml");
        }
        public IActionResult ShowSubjects()
        {
            return PartialView("~/Views/Admin/_tableSubject.cshtml");
        }
    }
}
