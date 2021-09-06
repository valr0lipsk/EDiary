using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AddStudent()
        {
            return PartialView("~/Views/Admin/_addStudent.cshtml");
        }
    }
}
