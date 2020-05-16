using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Eventique.Models;
using Eventique.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Identity;
using System.Security.Policy;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Eventique.Controllers
{
    public class HomeController : Controller
    {
        List<string> picList = new List<string>();
        private IHostingEnvironment Environment;
        private readonly ApplicationDbContext context;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;


        public HomeController(ApplicationDbContext _context , IHostingEnvironment _environment, UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            context = _context;
            Environment = _environment;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View(context.Photographers.ToList());
        }
        public IActionResult designerShow(int id)
        {

            Designer p = new Designer();
            p = context.Designers.Where(p => p.ID == id).FirstOrDefault();
            context.Reviews.ToList();
            context.InvitationCards.ToList();
            return View(p);
        }

        [Authorize(Roles = "User")]
        public IActionResult MyDeals()
        {
            var user = User.FindFirst(ClaimTypes.NameIdentifier);
            context.Users.ToList();
            context.Photographers.ToList();
            context.Hotels.ToList();
            context.Designers.ToList();
            try
            {
                ViewData["phoRequest"] = context.PhotographerRequests.Where(p => p.RequestUser.Users.Id == user.Value)?.ToList();
            }
            catch (Exception)
            {
                ViewData["phoRequest"] = new List<PhotographerRequest>().ToList();
            }
            try
            {
                ViewData["WeddRequest"] = context.WeddingHallsRequests.Where(w => w.RequestUser.Users.Id == user.Value)?.ToList();
            }
            catch (Exception)
            {
                ViewData["WeddRequest"] = new List<WeddingHallsRequest>().ToList();
            }
            try
            {
                ViewData["DesiRequest"] = context.DesignerRequests.Where(d => d.RequestUser.Users.Id == user.Value)?.ToList();

            }
            catch (Exception)
            {
                ViewData["DesiRequest"] = new List<DesignerRequest>().ToList();
            }
            return View();
        }

        //public IActionResult getOneDesigner(int id)
        //{
        //    Designer p = new Designer();
        //    p = context.Designers.Where(p => p.ID == id).FirstOrDefault();
        //    context.Reviews.ToList();
        //    context.InvitationCards.ToList();
        //    return View(p);
        //}
        //public IActionResult DedignerProfile()
        //{
        //    return View(context.Photographers.ToList());
        //}
        //public IActionResult designerShow()
        //{

        //    return View(context.Designers.ToList());
        //}



        public IActionResult PhotoghrapherShow()
        {
            return View(context.Photographers.ToList());
        }

        public IActionResult AllDesigners()
        {
            context.Reviews.ToList();
            return View(context.Designers.ToList());

        }
        public IActionResult TestView()
        {
            return View(context.Photographers.ToList());
        }

        public IActionResult AllWeddingHalls()
        {
            context.Albums.ToList();
            context.Images.ToList();
            return View(context.Hotels.ToList());
        }

        public IActionResult AllPhotographers()
        {
            return View(context.Photographers.ToList());
        }
        
        public IActionResult TestWeddView(int id)
        {
            WeddingHall hall = new WeddingHall();
            hall = context.Hotels.Where(h => h.ID == id).FirstOrDefault();
            context.Albums.ToList();
            context.Images.ToList();
            context.Users.ToList();
            return View(hall);
        }

        public IActionResult TestDesiView(int id)
        {
            Designer D = new Designer();
            D = context.Designers.Where(d => d.ID == id).FirstOrDefault();
            context.Albums.ToList();
            context.Images.ToList();
            context.InvitationCards.ToList();
            context.Users.ToList();
            return View(D);
        }
        public IActionResult TestPhoView(int id)
        {
            Photographer p = new Photographer();
            p = context.Photographers.Where(p => p.Ph_Id == id).FirstOrDefault();
            context.Albums.ToList();
            context.Images.ToList();
            return View(p);
        }

        
        [HttpPost]
        [Authorize(Roles = "User")]

        public IActionResult PostReview(int id,Review review)
        {
            Photographer photographer = context.Photographers.Where(p => p.Ph_Id== id).FirstOrDefault();
            var user = User.FindFirst(ClaimTypes.NameIdentifier);
            context.Users.ToList();
            Member member = context.Members.Where(m => m.Users.Id == user.Value).FirstOrDefault();
            if (ModelState.IsValid)
            {
                photographer.Ph_Reviews.Add(new Review()
                {
                    Quality = review.Quality,
                    DeleverTime = review.DeleverTime,
                    TimeManagement = review.TimeManagement,
                    ReviewMessage = review.ReviewMessage,
                    ReviewDate = DateTime.Now,
                    ReviewedMember = member
                }) ;                
                context.SaveChanges();
                return RedirectToAction("TestPhoView", new { id = photographer.Ph_Id });
            }
            return View(photographer);
        }

        [Authorize(Roles = "User")]

        public IActionResult GetAllReviews(int id)
        {
            context.Reviews.ToList();
            Photographer photographer = context.Photographers.Where(p => p.Ph_Id == id).FirstOrDefault();
            List<Review> reviews = photographer.Ph_Reviews;
            context.Members.ToList();
            return View(reviews);
        }

        public IActionResult PhoView(int id)
        {
            Photographer p = new Photographer();
            p = context.Photographers.Where(p => p.Ph_Id == id).FirstOrDefault();
            context.Albums.ToList();
            context.Images.ToList();
            return View(p);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        //function for photographer requests 
        [HttpPost]
        [Authorize(Roles = "User")]
        public IActionResult PhoRequest(int id , PhotographerRequest p)
        {
            PhotographerRequest pr = new PhotographerRequest();
            var user = User.FindFirst(ClaimTypes.NameIdentifier);
            Photographer po = context.Photographers.Where(p => p.Ph_Id == id).FirstOrDefault();
            context.Users.ToList();
            var member = context.Members.Where(m => m.Users.Id == user.Value).FirstOrDefault();
            pr.RequestPhotographer = po;
            pr.Date = p.Date;
            pr.RequestUser = member;
            pr.Message = p.Message;
            pr.Status = "Pending";
            context.PhotographerRequests.Add(pr);
            context.SaveChanges();
            return RedirectToAction("TestPhoView", new { id = id }); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
