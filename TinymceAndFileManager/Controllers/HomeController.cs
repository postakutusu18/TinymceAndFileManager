using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TinymceAndFileManager.Models;

namespace TinymceAndFileManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult FmEditor()
        {
            return View(new PageData { Baslik = "Metin Başlığı", Icerik = "Metin İçerik" }); 
        }
        [HttpPost]
        public IActionResult FmEditor(PageData data)
        {
            string baslik = data.Baslik;
            string icerik = data.Icerik;
            data.Sonuc = data.Icerik;
            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
