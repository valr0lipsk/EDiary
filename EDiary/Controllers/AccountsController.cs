using EDiary.IRepositories;
using EDiary.Models;
using EDiary.Repositories;
using EDiary.Service;
using Microsoft.AspNetCore.Mvc;
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
        public AccountsController(EDContext context)
        {
            this.context = context;
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
            return View(/*subjects*/);
        }
    }
}
