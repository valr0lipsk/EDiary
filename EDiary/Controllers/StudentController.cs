using EDiary.Models;
using EDiary.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        EDContext context;
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;
        public StudentController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, EDContext context) => (this.userManager, this.signInManager, this.context) = (userManager, signInManager, context);

        public IActionResult Student()
        {
            SqlConnection con = new SqlConnection(Config.ConnectionString);
            con.Open();
            var fullname = new SqlCommand($@"select concat(B.userSurname,' ',B.userName, ' ', B.userLastname) as fullname from users B inner join AspNetUsers E on B.userId=E.Id where B.userId={userManager.GetUserId(User)}", con).ExecuteScalar().ToString();
            ViewBag.name = fullname;
            return View();
        }
    }
}
