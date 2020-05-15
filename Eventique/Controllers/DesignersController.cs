using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Eventique.Data;
using Eventique.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eventique.Controllers
{
    public class DesignersController : Controller
    {
        private readonly ApplicationDbContext context;
        private IHostingEnvironment Environment;

        public DesignersController(ApplicationDbContext _context, IHostingEnvironment _environment)
        {
            context = _context;
            Environment = _environment;
        }


        public IActionResult TestDesiEdit(int id)
        {
            Designer d = new Designer();
            d = context.Designers.Where(des => des.ID == id).FirstOrDefault();
            context.Images.ToList();
            context.Reviews.ToList();
            context.InvitationCards.ToList();
            context.Users.ToList();
            return View(d);
        }

        public IActionResult NewTestDesiEdit()
        {
            return View();
        }
        public IActionResult CreateNewInvitation(int id)
        {
            Designer d = new Designer();
            context.Images.ToList();
            context.InvitationCards.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewInvitation(int id, InvitationCard b)
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
            b.Img = imgP[0];
            Designer po = new Designer();
            po = context.Designers.Where(s => s.ID == id).FirstOrDefault();
            context.Images.ToList();
            context.InvitationCards.Add(b);
            po.Invitations.Add(b);
            context.SaveChanges();
            return RedirectToAction("TestDesiEdit", new { id = id });
        }



        public IActionResult EditDesi(int id)
        {
            Designer d = new Designer();
            d = context.Designers.Where(p => p.ID == id).FirstOrDefault();
            context.Images.ToList();
            context.Users.ToList();
            return View(d);
        }

        [HttpPost]
        public IActionResult EditDesi(Designer p)
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
                            Designer edited = new Designer();
                            edited = context.Designers.Where(po => po.ID == p.ID).FirstOrDefault();
                            edited.Name = p.Name;
                            edited.PhoneNumber = p.PhoneNumber;
                            edited.Address = p.Address;
                            edited.Offers = p.Offers;
                            edited.ShopName = p.ShopName;
                            edited.Designer_ImgPath = imgP;
                            context.SaveChanges();
                            return RedirectToAction("TestDesiEdit", new { id = p.ID });
                        }

                    }
                }
                else
                {
                    Designer edited = new Designer();
                    edited = context.Designers.Where(po => po.ID == p.ID).FirstOrDefault();
                    edited.Name = p.Name;
                    edited.PhoneNumber = p.PhoneNumber;
                    edited.Address = p.Address;
                    edited.Offers = p.Offers;
                    edited.Designer_ImgPath = p.Designer_ImgPath;
                    context.SaveChanges();
                    return RedirectToAction("TestDesiEdit", new { id = p.ID });

                }


            }

            return View(p);
        }

        [HttpGet]
        [Route("Designers/find/{id}")]
        public IActionResult Find(int id)
        {
            var invitation = context.InvitationCards.Find(id);
            ArrayList li = new ArrayList();
            li.Add(invitation.Inv_Id.ToString());
            li.Add(invitation.Inv_Title);
            li.Add(invitation.Inv_Price);
            Dictionary<string, string> EmployeeList = new Dictionary<string, string>();
            EmployeeList.Add("Inv_Id", invitation.Inv_Id.ToString());
            EmployeeList.Add("Inv_Title", invitation.Inv_Title);
            EmployeeList.Add("Inv_Price", invitation.Inv_Price.ToString());
            return new JsonResult(EmployeeList);
        }


        [HttpPost]
        [Route("Update")]

        public IActionResult Update(string Inv_Id, string Inv_Title, string Inv_Price)
        {
            var invitation = context.InvitationCards.Find(int.Parse(Inv_Id));
            invitation.Inv_Title = Inv_Title;
            invitation.Inv_Price = float.Parse(Inv_Price);
            Designer des = context.Designers.Where(d => d.Invitations.Where(i => i.Inv_Id == int.Parse(Inv_Id)).FirstOrDefault().Inv_Id == invitation.Inv_Id).FirstOrDefault();
            context.SaveChanges();
            return RedirectToAction("TestDesiEdit", new { id = des.ID });
        }
    }

}

