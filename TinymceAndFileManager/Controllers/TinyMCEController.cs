using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TinymceAndFileManager.Controllers
{
    [Route("tiny-mce")]
    public class TinyMCEController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("browse")]
        public IActionResult Browse()
        {
            return View();
        }
    }
}
