﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDiary.Controllers
{
    public class MarksController : Controller
    {
        public IActionResult Jurnal()
        {
            return View();
        }
    }
}
