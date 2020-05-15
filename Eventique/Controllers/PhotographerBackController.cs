using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventique.Data;
using Eventique.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Eventique.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PhotographerBackController : Controller
    {
        ApplicationDbContext context;
        public PhotographerBackController(ApplicationDbContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            return View(context.Photographers.ToList());
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create(string Ph_Name)
        {
            Photographer p = new Photographer()
            {
                Ph_Name = Ph_Name,
            };
            context.Photographers.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("Remove")]
        public IActionResult Remove(int id)
        {
            var photographer = context.Photographers.Find(id);
            context.Photographers.Remove(photographer);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("PhotographerBack/find/{id}")]
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


        //[HttpPost]
        //[Route("Update")]
        //public IActionResult Update(string Pho_Id, string Pho_Name)
        //{
        //    var photographer = context.Photographers.Find(int.Parse(Pho_Id));
        //    //photographer.Ph_Id = Ph_Id;
        //    photographer.Ph_Name = Pho_Name;
        //    context.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}