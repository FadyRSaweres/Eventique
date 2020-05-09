using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Eventique.Models;
using Eventique.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Eventique.Controllers
{
    public class HomeController : Controller
    {
        List<string> picList = new List<string>();
        private IHostingEnvironment Environment;
        private readonly ApplicationDbContext context;

        public HomeController(ApplicationDbContext _context , IHostingEnvironment _environment)
        {
            context = _context;
            Environment = _environment;
        }
        //public IActionResult Index()
        //{
        //    return View(context.Photographers.ToList());
        //}
        public IActionResult designerShow()
        {

            return View(context.Designers.ToList());
        }
        public IActionResult PhotoghrapherShow()
        {

            return View(context.Photographers.ToList());
        }
        public IActionResult MyDeals()
        {
            return View();
        }
        public IActionResult AllDesigners()
        {

            return View();

        }
        public IActionResult TestView()
        {
            return View(context.Photographers.ToList());
        }

        public IActionResult AllWeddingHalls()
        {
            return View(context.Hotels.ToList());
        }

        public IActionResult AllPhotographers()
        {
            return View(context.Photographers.ToList());
        }


        public IActionResult PhoView(int id)
        {
            Photographer p = new Photographer();
            p = context.Photographers.Where(p => p.Ph_Id == id).FirstOrDefault();
            context.Albums.ToList();
            context.Images.ToList();
            return View(p);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Upload(List<IFormFile> postedFiles)
        {
            string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;

            string path = Path.Combine(this.Environment.WebRootPath, "Images");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            List<string> uploadedFiles = new List<string>();
            foreach (IFormFile postedFile in postedFiles)
            {
                string fileName = Path.GetFileName(postedFile.FileName);
                using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                    uploadedFiles.Add(fileName);
                    ViewBag.Message += string.Format("<b>{0}</b> uploaded.<br />", fileName);
                }
            }

            return View("Upload");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
