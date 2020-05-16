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
using Microsoft.AspNetCore.Authorization;

namespace Eventique.Controllers
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
        [Route("Create")]
        public IActionResult Create(string Ph_Name , string Ph_Address , string Ph_PhoneNumber)
        {
            Photographer p = new Photographer()
            {
                Ph_Name = Ph_Name,
                Ph_Address=Ph_Address,
                Ph_PhoneNumber=Ph_PhoneNumber
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
        [Route("Photoers/Find/{id}")]
        public IActionResult Find(int id)
        {
            var Photographer = context.Photographers.Find(id);
            //ArrayList li = new ArrayList();
            //li.Add(Photographer.Ph_Id);
            //li.Add(Photographer.Ph_Name);
            //li.Add(Photographer.Ph_Address);
            //li.Add(Photographer.Ph_PhoneNumber);
            Dictionary<string, string> EmployeeList = new Dictionary<string, string>();
            EmployeeList.Add("Ph_Id", Photographer.Ph_Id.ToString());
            EmployeeList.Add("Ph_Name", Photographer.Ph_Name);
            EmployeeList.Add("Ph_Address", Photographer.Ph_Address);
            EmployeeList.Add("Ph_PhoneNumber", Photographer.Ph_PhoneNumber);

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
        [HttpPost]
        [Route("Update")]
        public IActionResult Update(int Ph_Id, string Ph_Name , string Ph_Address , string Ph_Phone)
        {
            var photographer = context.Photographers.Find(Ph_Id);
            //photographer.Ph_Id = Ph_Id;
            photographer.Ph_Name = Ph_Name;
            photographer.Ph_Address = Ph_Address;
            photographer.Ph_PhoneNumber = Ph_Phone;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
