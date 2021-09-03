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
        public AccountsController(EDContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
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
        public IActionResult Teacher()
        {
            //Users users = (Users)context.users.Where(u => u. == 1);
            //Teacher teacher = (Teacher)context.teachers.Where(c => c.teacherId == users.idUser);
            //subjectTaught subjectTaught = (subjectTaught)context.subjectTaughts.Where(c => c.teacherId == teacher.teacherId);
            //var subjects = (from subject in context.subjects
            //                            where subject.subjectId == subjectTaught.subjectId 
            //                            select subject).ToList();
            SqlConnection con = new SqlConnection(Config.ConnectionString);
            con.Open();
            var surname = new SqlCommand($@"select B.userSurname from users B inner join AspNetUsers E on B.userId=E.Id where B.userId={userManager.GetUserId(User)}",con).ExecuteScalar().ToString();
            var name = new SqlCommand($@"select B.userName from users B inner join AspNetUsers E on B.userId=E.Id where B.userId={userManager.GetUserId(User)}", con).ExecuteScalar().ToString();
            var lastname = new SqlCommand($@"select B.userLastname from users B inner join AspNetUsers E on B.userId=E.Id where B.userId={userManager.GetUserId(User)}", con).ExecuteScalar().ToString();
            string fullname = string.Join(" ", surname, name, lastname);
            ViewBag.name = fullname;
            return View(/*subjects*/);
        }
    }
}
