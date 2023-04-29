using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNet_Intro.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            return View(nums);
        }
    }
}

