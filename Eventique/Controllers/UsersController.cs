using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Eventique.Data;
using Eventique.Models;

namespace Eventique.Controllers.Admin
{
    public class UsersController : Controller
    {
        ApplicationDbContext context;
        public UsersController(ApplicationDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View(context.Members.ToList());
        }
        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUser(string Name, int PhoneNumber)
        {
            var member = new Member
            {

                Name = Name,
                PhoneNumber = PhoneNumber,
               
            };
            context.Members.Add(member);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpPost]
        [Route("RemoveUser")]
        public IActionResult RemoveUser(int id)
        {
            var member = context.Members.Find(id);
            context.Members.Remove(member);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("Users/FindUser/{id}")]
        public IActionResult FindUser(int id)
        {
            var member = context.Members.Find(id);
            Dictionary<string, string> UList = new Dictionary<string, string>
            {
                { "ID", member.ID.ToString() },
                { "Name", member.Name },
                { "PhoneNumber", member.PhoneNumber.ToString() }
            };
            return new JsonResult(UList);
        }

        [HttpPost]
        [Route("UpdateUser")]
        public IActionResult UpdateUser(int ID, string Name, string PhoneNumber)
        {
            var member = context.Members.Find(ID);
            //designer.ID = ID;
            member.Name = Name;
            member.PhoneNumber = int.Parse(PhoneNumber);
            
           
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

