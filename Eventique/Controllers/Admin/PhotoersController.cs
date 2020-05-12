using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Eventique.Data;
using Eventique.Models;
using System.Collections;

namespace Eventique.Controllers.Admin
{
    public class PhotoersController : Controller
    {
        ApplicationDbContext context;
        public PhotoersController(ApplicationDbContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            return View(context.Photographers.ToList());
        }

        [HttpPost]
        [Route("CreatePhotographer")]
        public IActionResult Create(string Ph_Name  ,string Ph_Address  )
        {
            Photographer p = new Photographer()
            {
                Ph_Name = Ph_Name,
                Ph_Address= Ph_Address,
                

            };
            context.Photographers.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("RemovePhotographer")]
        public IActionResult Remove(int id)
        {
            var photographer = context.Photographers.Find(id);
            context.Photographers.Remove(photographer);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("Photographers/FindPhotographer/{id}")]
        public IActionResult Find(int id)
        {
            var Photographer = context.Photographers.Find(id);
            ArrayList li = new ArrayList();
            li.Add(Photographer.Ph_Id);
            li.Add(Photographer.Ph_Name);
            Dictionary<string, string> EmployeeList = new Dictionary<string, string>();
            EmployeeList.Add("Ph_Id", Photographer.Ph_Id.ToString());
            EmployeeList.Add("Ph_Name", Photographer.Ph_Name);
            return new JsonResult(EmployeeList);
        }


        [HttpPost]
        [Route("Updatephotographer")]
        public IActionResult Update(string Pho_Id, string Name , string Address)
        {
            var photographer = context.Photographers.Find(int.Parse(Pho_Id));
           //photographer.Ph_Id = Ph_Id;
            photographer.Ph_Name= Name;
            photographer.Ph_Address = Address;
            
           
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
