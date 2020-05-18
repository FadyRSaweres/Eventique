using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Eventique.Data;
using Eventique.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eventique.Controllers
{
    public class WeddingHallsController : Controller
    {

        private readonly ApplicationDbContext context;
        private IHostingEnvironment Environment;
        public WeddingHallsController(ApplicationDbContext _context, IHostingEnvironment _environment)
        {
            context = _context;
            Environment = _environment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TestWeddEdit()
        {
            try
            {
                var user = User.FindFirst(ClaimTypes.NameIdentifier);
                WeddingHall wh = context.Hotels.Where(h => h.Users.Id == user.Value).FirstOrDefault();
                if (wh != null)
                {
                    context.Users.ToList();
                    context.Reviews.ToList();
                    context.WeddingHallsRequests.ToList();
                    context.Images.ToList();
                    context.Albums.ToList();
                    return View(wh);
                }
                else
                {
                    return RedirectToAction("AccessDeniedPage");
                }
            }
            catch(Exception)
            {
                return RedirectToAction("AccessDeniedPage");

            }
        }

        public IActionResult EditWedd()
        {
            var user = User.FindFirst(ClaimTypes.NameIdentifier);
            WeddingHall wh = context.Hotels.Where(h => h.Users.Id == user.Value).FirstOrDefault();
            context.Albums.ToList();
            context.Images.ToList();
            context.Users.ToList();
            return View(wh);
        }


        [HttpPost]
        public IActionResult EditWedd(WeddingHall wed)
        {
            var user = User.FindFirst(ClaimTypes.NameIdentifier);
            WeddingHall wh = context.Hotels.Where(h => h.Users.Id == user.Value).FirstOrDefault();
            if (ModelState != null)
            {
                string wwwPath = this.Environment.WebRootPath;
                string contentPath = this.Environment.ContentRootPath;
                List<Image> imgPForAlbum = new List<Image>();
                string path = Path.Combine(this.Environment.WebRootPath, "Images");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                List<string> uploadedFiles = new List<string>();
                if (wed.ImageFilePath != null || wed.ImageFilePathAlbum != null)
                {
                    foreach (IFormFile postedFile in wed.ImageFilePath)
                    {
                        string fileName = Path.GetFileName(postedFile.FileName);
                        using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                        {
                            postedFile.CopyTo(stream);
                            uploadedFiles.Add(fileName);
                            string imgP = "/Images/" + fileName;
                            wh.Hall_ImgPath = imgP;
                        }

                    }
                    foreach (IFormFile postedFile in wed.ImageFilePathAlbum)
                    {
                        string fileName = Path.GetFileName(postedFile.FileName);
                        using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                        {
                            postedFile.CopyTo(stream);
                            uploadedFiles.Add(fileName);
                            imgPForAlbum.Add(new Image() { Img_Path = "/Images/" + fileName });

                        }

                    }

                    wh.Name = wed.Name;
                    wh.PhoneNumber = wed.PhoneNumber;
                    wh.Hall_Price = wed.Hall_Price;
                    wh.HallType = wed.HallType;
                    wh.Address = wed.Address;
                    wh.OtherServices = wed.OtherServices;
                    wh.TestDate = wed.TestDate;
                    wh.Album = new Album() { Al_Title = wed.Name , MyProperty = imgPForAlbum };
                    wh.Offers = wed.Offers;
                    context.SaveChanges();
                    return RedirectToAction("TestWeddEdit");

                }
                else
                {
                    wh.Name = wed.Name;
                    wh.PhoneNumber = wed.PhoneNumber;
                    wh.Hall_Price = wed.Hall_Price;
                    wh.HallType = wed.HallType;
                    wh.Address = wed.Address;
                    wh.OtherServices = wed.OtherServices;
                    wh.TestDate = wed.TestDate;
                    wh.Offers = wed.Offers;
                    context.SaveChanges();
                    return RedirectToAction("TestWeddEdit");

                }


            }

            return View(wh);
        }



        public IActionResult Deals()
        {
            var user = User.FindFirst(ClaimTypes.NameIdentifier);
            WeddingHall wh = context.Hotels.Where(h => h.Users.Id == user.Value).FirstOrDefault();
            //p = context.Photographers.Where(p => p.Ph_Id == id).FirstOrDefault();
            context.Images.ToList();
            context.Users.ToList();
            context.WeddingHallsRequests.ToList();
            context.Members.ToList();
            return View(wh);
        }

        [HttpPost]
        public IActionResult AcceptDeal(int id)
        {
            WeddingHallsRequest wh = context.WeddingHallsRequests.Where(fr => fr.ID == id).FirstOrDefault();
            wh.Status = "Accepted";
            context.SaveChanges();
            //GMailer.GmailUsername = "fady.ragaa48@gmail.com";
            //GMailer.GmailPassword = "fady2020";

            //GMailer mailer = new GMailer();
            //mailer.ToEmail = "bahersaweres@gmail.com";
            //mailer.Subject = "Eventique Website";
            //mailer.Body = "Thanks for Registering your Booking .<br> your booking accepted now</a>";
            //mailer.IsHtml = false;
            //mailer.Send();
            return RedirectToAction("Deals");
        }

        [HttpPost]
        public IActionResult CancelDeal(int id)
        {
            WeddingHallsRequest wh = context.WeddingHallsRequests.Where(fr => fr.ID == id).FirstOrDefault();
            wh.Status = "Canceled";
            context.SaveChanges();
            //GMailer.GmailUsername = "fady.ragaa48@gmail.com";
            //GMailer.GmailPassword = "fady2020";

            //GMailer mailer = new GMailer();
            //mailer.ToEmail = "bahersaweres@gmail.com";
            //mailer.Subject = "Eventique Website";
            //mailer.Body = "Thanks for Registering your Booking .<br> your booking accepted now</a>";
            //mailer.IsHtml = false;
            //mailer.Send();
            return RedirectToAction("Deals");
        }
        public IActionResult AccessDeniedPage()
        {
            return View();
        }
    }
}