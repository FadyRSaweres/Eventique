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
        [Route("AddMember")]
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
        [Route("RemoveMember")]
        public IActionResult RemoveUser(int id)
        {
            var member = context.Members.Find(id);
            context.Members.Remove(member);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("Members/FindMembers/{id}")]
        public IActionResult FindUser(int id)
        {
            var member = context.Members.Find(id);
            Dictionary<string, string> DList = new Dictionary<string, string>();
            DList.Add("ID", member.ID.ToString());
            DList.Add("Name", member.Name);
            DList.Add("PhoneNumber", member.PhoneNumber.ToString());
            return new JsonResult(DList);
        }

        [HttpPost]
        [Route("UpdateMember")]
        public IActionResult UpdateUser(string ID, string Name, string PhoneNumber, string Address, string ShopName)
        {
            var member = context.Members.Find(int.Parse(ID));
            //designer.ID = ID;
            member.Name = Name;
            member.PhoneNumber = int.Parse(PhoneNumber);
           
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

