using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Controllers
{
    public class MarksController : Controller
    {
        //представление журнала
        //public IActionResult Jurnal()
        //{
        //    return View();
        //}

        [HttpGet]
        public IActionResult Jurnal(int id)
        {
            var subid = id;
            return View();
        }
    }
}
