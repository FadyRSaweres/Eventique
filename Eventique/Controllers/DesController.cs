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
using Microsoft.AspNetCore.Identity;
using Eventique.Areas.Identity.Pages.Account;
using static Eventique.Areas.Identity.Pages.Account.ExternalLoginModel;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eventique.Controllers.Admin
{
    public class DesController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        ApplicationDbContext context;
        public DesController(ApplicationDbContext _context, UserManager<IdentityUser> userManager,
             SignInManager<IdentityUser> signInManager)
        {
            context = _context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            
            context.Users.ToList();
            return View(context.Designers.ToList());
        }
        [HttpPost]
        [Route("AddDesigner")]
        public async Task< IActionResult> AddDesigner(string Name, int PhoneNumber, string Address, string ShopName , string _Email , string _Password)
        {
            var user = new IdentityUser { Email=_Email , UserName=_Email,NormalizedEmail=_Email.ToUpper()};

            var result = await _userManager.CreateAsync(user, _Password);
            await _userManager.AddToRoleAsync(user, "Designer");
            await _signInManager.SignInAsync(user, isPersistent: false);

            var designer = new Designer
            {

                Name = Name,
                PhoneNumber = PhoneNumber,
                Address = Address,
                ShopName = ShopName,
               Users=user
            };
            context.Designers.Add(designer);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        //private UserManager<IdentityUser> userManager;

        ////public DesController()
        ////{

        ////}

        //ApplicationDbContext context;
        //public DesController(ApplicationDbContext _context, UserManager<IdentityUser> usrMgr)
        //{
        //    context = _context;
        //    userManager = usrMgr;
        //}
        //public IActionResult Index()
        //{
        //    return View(context.Designers.ToList());
        //}
        //public class InputModel
        //{
        //    [Required]
        //    [EmailAddress]
        //    [Display(Name = "Email")]
        //    public string Email { get; set; }

        //    [Required]
        //    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        //    [DataType(DataType.Password)]
        //    [Display(Name = "Password")]
        //    public string Password { get; set; }
        //    public string Role { get; set; }
        //    public string UserName { get; set; }
        //    public string PhoneNumber { get; set; }

        //    [DataType(DataType.Password)]
        //    [Display(Name = "Confirm password")]
        //    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        //    public string ConfirmPassword { get; set; }
        //}




        //    [HttpPost]
        //[Route("AddDesigner")]
        //public IActionResult AddDesigner(string Name, int PhoneNumber, string Address, string ShopName , IdentityUser UserId)
        //{

        //InputModel Input = new InputModel();

        //    UserId = new IdentityUser {UserName=Input.UserName, Email = Input.Email,PhoneNumber=Input.PhoneNumber};

        //    var designer = new Designer
        //    {

        //        Name = Name,
        //        PhoneNumber = PhoneNumber,
        //        Address = Address,
        //        ShopName = ShopName,
        //        Users = UserId,

        //};
        //    userManager.CreateAsync(UserId,Input.Password);
        //    context.Designers.Add(designer);
        //    context.SaveChanges();
        //    return RedirectToAction("Index");
        //}


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
        [Route("Des/FindDesigner/{id}")]
        public IActionResult FindDesigner(int id)
        {
            var designer = context.Designers.Find(id);

            Dictionary<string, string> DList = new Dictionary<string, string>();
            DList.Add("ID", designer.ID.ToString());
            DList.Add("Name", designer.Name);
            DList.Add("PhoneNumber", designer.PhoneNumber.ToString());
            DList.Add("Address", designer.Address);
            DList.Add("ShopName", designer.ShopName);
            
            return new JsonResult(DList);
        }

        [HttpPost]
        [Route("UpdateDesigner")]
        public IActionResult UpdateDesigner(int ID, string Name, string PhoneNumber, string Address, string ShopName )
        {
            //var designer = context.Designers.Where(d => d.ID == ID).FirstOrDefault();
            var designer = context.Designers.Find(ID);
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
