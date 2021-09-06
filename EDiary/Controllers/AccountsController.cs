using EDiary.IRepositories;
using EDiary.Models;
using EDiary.Repositories;
using EDiary.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ILogger<AccountsController> _logger;
        EDContext context;
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;
        public string fullname { get; set; }
        public AccountsController(EDContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager) => (this.userManager, this.signInManager, this.context) = (userManager, signInManager,context);
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Admin()
        {
            return View();
        }
        //public async Task<IActionResult> Teacher()
        //{
        //    return View(await context.subjectTaughts.ToListAsync());
        //}
        public IActionResult Student()
        {
            SqlConnection con = new SqlConnection(Config.ConnectionString);
            con.Open();
            var fullname = new SqlCommand($@"select concat(B.userSurname,' ',B.userName, ' ', B.userLastname) as fullname from users B inner join AspNetUsers E on B.userId=E.Id where B.userId={userManager.GetUserId(User)}", con).ExecuteScalar().ToString();
            ViewBag.name = fullname;
            return View();
        }
        public async Task<IActionResult> Teacher()
        {
            SqlConnection con = new SqlConnection(Config.ConnectionString);
            con.Open();
            var fullname = new SqlCommand($@"select concat(B.userSurname,' ',B.userName, ' ', B.userLastname) as fullname from users B inner join AspNetUsers E on B.userId=E.Id where B.userId={userManager.GetUserId(User)}", con).ExecuteScalar().ToString();
            ViewBag.name = fullname;
            var subjectsLINQ = (from tsub in context.subjectTaughts
                                join st in context.subjects on tsub.subjectId equals st.subjectId
                                /*join gr in context.groups on tsub.groupId equals gr.groupId*/
                                join tr in context.teachers on tsub.teacherId equals tr.teacherId
                                join us in context.users on tr.teacherUser equals us.idUser
                                join aspusers in context.Users on us.userId equals aspusers.Id
                                where aspusers.Id == userManager.GetUserId(User)
                                select new Subject
                                {
                                    subjectName = st.subjectName,
                                    subjectId = tsub.tsubjectId
                                });
            return View(await subjectsLINQ.ToListAsync());
        }
    }
}
