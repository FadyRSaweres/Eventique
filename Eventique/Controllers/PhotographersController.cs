﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Eventique.Data;
using Eventique.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Eventique.Controllers
{
    [Authorize(Roles = "Photographer")]
    public class PhotographersController : Controller
    {
        private readonly ApplicationDbContext context;
        private IHostingEnvironment Environment; 


        public PhotographersController(ApplicationDbContext _context , IHostingEnvironment _environment)
        {
            context = _context;
            Environment = _environment;
        }
        public IActionResult Index()
        {
            Photographer p = new Photographer();
            return View();
        }

        //public IActionResult PhoEdit(int id)
        //{
        //    Photographer p = new Photographer();
        //    p = context.Photographers.Where(p => p.Ph_Id == id).FirstOrDefault();
        //    context.Albums.ToList();
        //    context.Images.ToList();
        //    context.Users.ToList();
        //    return View(p);
        //}

        public IActionResult TestPhoEdit(int id)
        {
            Photographer p = new Photographer();
            p = context.Photographers.Where(p => p.Ph_Id == id).FirstOrDefault();
            context.Albums.ToList();
            context.Reviews.ToList();
            context.Members.ToList();
            context.Images.ToList();
            context.Users.ToList();
            context.PhotographerRequests.ToList();
            context.Members.ToList();

            return View(p);
        }
        //public IActionResult CreateAlbum()
        //{
        //    Photographer p = new Photographer();
        //    //p = context.Photographers.Where(p => p.Ph_Id == id).FirstOrDefault();
        //    context.Albums.ToList();
        //    context.Images.ToList();
        //    return View();
        //}
        public IActionResult CreateNewAlbum()
        {
            Photographer p = new Photographer();
            //p = context.Photographers.Where(p => p.Ph_Id == id).FirstOrDefault();
            context.Albums.ToList();
            context.Images.ToList();
            return View();
        }

   
        [HttpPost]
        public IActionResult CreateNewAlbum(int id, Album b)
        {
            string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;

            string path = Path.Combine(this.Environment.WebRootPath, "Images");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            List<Image> imgP = new List<Image>();
            List<string> uploadedFiles = new List<string>();
            foreach (IFormFile postedFile in b.ImageFilePath)
            {
                string fileName = Path.GetFileName(postedFile.FileName);
                using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                    uploadedFiles.Add(fileName);
                    imgP.Add(new Image() { Img_Path = "/Images/" + fileName });
                }

            }
           
            b.MyProperty = imgP;
            Photographer po = new Photographer();
            po = context.Photographers.Where(s => s.Ph_Id == id).FirstOrDefault();
            context.Albums.ToList();
            context.Images.ToList();
            context.Albums.Add(b);
            po.ListAlbum.Add(b);
            context.SaveChanges();
            return RedirectToAction("TestPhoEdit", new { id = id });
        }



        public IActionResult EditPho(int id)
        {
            Photographer p = new Photographer();
            p = context.Photographers.Where(p => p.Ph_Id == id).FirstOrDefault();
            context.Albums.ToList();
            context.Images.ToList();
            context.Users.ToList();
            return View(p);
        }

        [HttpPost]
        public IActionResult EditPho(Photographer p)
        {
            if (ModelState != null)
            {
                string wwwPath = this.Environment.WebRootPath;
                string contentPath = this.Environment.ContentRootPath;

                string path = Path.Combine(this.Environment.WebRootPath, "Images");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                List<string> uploadedFiles = new List<string>();
                if (p.ImageFilePath != null)
                {
                    foreach (IFormFile postedFile in p.ImageFilePath)
                    {
                        string fileName = Path.GetFileName(postedFile.FileName);
                        using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                        {
                            postedFile.CopyTo(stream);
                            uploadedFiles.Add(fileName);
                            string imgP = "/Images/" + fileName;
                            Photographer edited = new Photographer();
                            edited = context.Photographers.Where(po => po.Ph_Id == p.Ph_Id).FirstOrDefault();
                            edited.Ph_Name = p.Ph_Name;
                            edited.Ph_PhoneNumber = p.Ph_PhoneNumber;
                            edited.Ph_Price = p.Ph_Price;
                            edited.Ph_Address = p.Ph_Address;
                            edited.Ph_CameraType = p.Ph_CameraType;
                            edited.Ph_Offers = p.Ph_Offers;
                            edited.Description = p.Description;
                            edited.ImagePath = imgP;
                            edited.TestDate = p.TestDate;
                            context.SaveChanges();
                            return RedirectToAction("TestPhoEdit", new { id = p.Ph_Id });
                        }
                    }
                }
                else
                {
                    Photographer edited = new Photographer();
                    edited = context.Photographers.Where(po => po.Ph_Id == p.Ph_Id).FirstOrDefault();
                    edited.Ph_Name = p.Ph_Name;
                    edited.Ph_PhoneNumber = p.Ph_PhoneNumber;
                    edited.Ph_Price = p.Ph_Price;
                    edited.Ph_Address = p.Ph_Address;
                    edited.Ph_CameraType = p.Ph_CameraType;
                    edited.Ph_Offers = p.Ph_Offers;
                    edited.Description = p.Description;
                    edited.ImagePath = p.ImagePath;
                    edited.TestDate = p.TestDate;
                    context.SaveChanges();
                    return RedirectToAction("TestPhoEdit", new { id = p.Ph_Id });

                }
            }
            return View(p);
        }

        //For displaying deals in photographer page
        public IActionResult Deals()
        {
            var user = User.FindFirst(ClaimTypes.NameIdentifier);
            Photographer ph = context.Photographers.Where(h => h.Users.Id == user.Value).FirstOrDefault();
            //p = context.Photographers.Where(p => p.Ph_Id == id).FirstOrDefault();
            context.Images.ToList();
            context.Users.ToList();
            context.PhotographerRequests.ToList();
            context.Members.ToList();
            return View(ph);
        }

        [HttpPost]
        public IActionResult AcceptDeal (int id)
        {
            PhotographerRequest pr = context.PhotographerRequests.Where(fr => fr.ID == id).FirstOrDefault();
            pr.Status = "Accepted";
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
            PhotographerRequest pr = context.PhotographerRequests.Where(fr => fr.ID == id).FirstOrDefault();
            pr.Status = "Canceled";
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


    }
}