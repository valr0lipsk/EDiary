using EDiary.Models;
using EDiary.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Controllers
{
    public class AdminController : Controller
    {
        UserManager<IdentityUser> userManager;
        EDContext context;
        public AdminController(UserManager<IdentityUser> userManager) => this.userManager = userManager;
        public IActionResult Admin()
        {
            return View();
        }

        public async Task<IActionResult> AddStudent(CreateStudentModel createStudent)
        {
            if (ModelState.IsValid)
            {
                IdentityUser identityStudentUser = new IdentityUser { UserName = createStudent.studentLogin, PasswordHash=createStudent.studentPassword };
                Users studentUser = new Users {userSurname = createStudent.studentSurname, userName = createStudent.studentName, userLastname = createStudent.studentLastname };
                Student student = new Student { studentRole = "student", studentGroup = createStudent.studentGroup};
                var result = await userManager.CreateAsync(identityStudentUser, createStudent.studentPassword);
                if (result.Succeeded)
                {
                    return RedirectToAction("AddStudent");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            
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
