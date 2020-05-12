using System;
using System.Collections;
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
    public class DesController : Controller
    {
        

        ApplicationDbContext context;
        public DesController(ApplicationDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View(context.Designers.ToList());
        }
        [HttpPost]
        [Route("AddDesigner")]
        public IActionResult AddDesigner(string Name, int PhoneNumber , string Address ,string ShopName)
        {
            var designer = new Designer
            {

                Name = Name,
                PhoneNumber = PhoneNumber,
                Address= Address,
                ShopName= ShopName
            };
            context.Designers.Add(designer);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpPost]
        [Route("RemoveDesigner")]
        public IActionResult RemoveDesigner(int id)
        {
            var desinger = context.Designers.Find(id);
            context.Designers.Remove(desinger);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("Designers/FindDesigner/{id}")]
        public IActionResult FindDesigner(int id)
        {
            var designer = context.Designers.Find(id);
            Dictionary<string, string> DList = new Dictionary<string, string>();
            DList.Add("ID", designer.ID.ToString());
            DList.Add("Name", designer.Name);
            DList.Add("PhoneNumber", designer.PhoneNumber.ToString());
            return new JsonResult(DList);
        }

        [HttpPost]
        [Route("UpdateDesigner")]
        public IActionResult UpdateDesigner(string ID, string Name, string PhoneNumber , string Address, string ShopName)
        {
            var designer = context.Designers.Find(int.Parse(ID));
            //designer.ID = ID;
            designer.Name = Name;
            designer.PhoneNumber = int.Parse(PhoneNumber);
            designer.Address = Address;
            designer.ShopName = ShopName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
