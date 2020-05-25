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
using System.Collections;

namespace Eventique.Controllers
{
    public class HomeController : Controller
    {
        List<string> picList = new List<string>();
        private IHostingEnvironment Environment;
        private readonly ApplicationDbContext context;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly List<WeddingHall> halls = new List<WeddingHall>();


        public HomeController(ApplicationDbContext _context , IHostingEnvironment _environment, UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            context = _context;
            Environment = _environment;
            _userManager = userManager;
            _signInManager = signInManager;
            halls = context.Hotels.ToList();
        }
        public IActionResult Index()
        {
            return View(context.Photographers.ToList());
        }

        [Authorize(Roles = "User")]
        public IActionResult MyDeals()
        {
            var user = User.FindFirst(ClaimTypes.NameIdentifier);
            context.Users.ToList();
            context.Photographers.ToList();
            context.Hotels.ToList();
            context.InvitationCards.ToList();
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



        public IActionResult PhotoghrapherShow()
        {
            return View(context.Photographers.ToList());
        }

        public IActionResult AllDesigners()
        {
            context.Reviews.ToList();
            return View(context.Designers.ToList());

        }

        public IActionResult LastReco()
        {
            context.Hotels.ToList();
            context.Designers.ToList();
            context.Photographers.ToList();
            context.InvitationCards.ToList();
            return View(context.Recommendations.ToList());
        }
        public IActionResult TestView()
        {
            context.Members.ToList();
            ViewData["photo"] = context.Photographers.ToList();
            ViewData["halls"] = context.Hotels.ToList();
            ViewData["designers"] = context.Designers.ToList();
            ViewData["Reviews"] = context.Reviews.ToList();
            return View();
            
        }

        public IActionResult AllWeddingHalls(int Price = 5000, string HallType = null, string OtherServices = null, int Capacity = 100, string Regon = null, string Date = null)
        {
            context.Albums.ToList();
            context.Images.ToList();
            List<WeddingHall> wedHalls = new List<WeddingHall>();
            if(Date == "Next Month")
            {
                wedHalls = context.Hotels.Where(h => h.Hall_Price <= Price && h.HallType == HallType && h.OtherServices == OtherServices && h.Capacity <= Capacity && h.Address.Contains(Regon) && h.TestDate.Contains("-06-")).ToList();
            }
            else if(Date == "This Month")
            {
                wedHalls = context.Hotels.Where(h => h.Hall_Price <= Price && h.HallType == HallType && h.OtherServices == OtherServices && h.Capacity <= Capacity && h.Address.Contains(Regon) && h.TestDate.Contains("-05-")).ToList();
            }
            else if(Price == 5000 && HallType == null && OtherServices == null && Capacity == 100 && Regon == null && Date == null)
            {
                wedHalls = context.Hotels.ToList();
            }
            return View(wedHalls);
        }

        //public IActionResult Search(string Price , string HallType , string OtherServices , string Capacity , string Regon , string Date)
        //{
        //    return 
        //}

        public IActionResult AllPhotographers(int Price = 1000, string CameraType = null, string Regon = null, string Date = null)
        {
            List<Photographer> photographers = new List<Photographer>();
            if (Date == "Next Month")
            {
                photographers = context.Photographers.Where(h => h.Ph_Price <= Price && h.Ph_CameraType == CameraType && h.Ph_Address.Contains(Regon) && h.TestDate.Contains("-06-")).ToList();
            }
            else if (Date == "This Month")
            {
                photographers = context.Photographers.Where(h => h.Ph_Price <= Price && h.Ph_CameraType == CameraType && h.Ph_Address.Contains(Regon) && h.TestDate.Contains("-05-")).ToList();
            }
            else
            {
                photographers = context.Photographers.ToList();
            }
            return View(photographers);
        }
        
        public IActionResult TestWeddView(int id)
        {
            WeddingHall hall = new WeddingHall();
            hall = context.Hotels.Where(h => h.ID == id).FirstOrDefault();
            context.Albums.ToList();
            context.Images.ToList();
            context.Users.ToList();
            context.Reviews.ToList();
            context.Members.ToList();
            return View(hall);
        }

        public IActionResult TestDesiView(int id)
        {
            Designer D = new Designer();
            D = context.Designers.Where(d => d.ID == id).FirstOrDefault();
            context.Albums.ToList();
            context.Images.ToList();
            context.InvitationCards.ToList();
            context.Reviews.ToList();
            context.Users.ToList();
            context.Members.ToList();
            return View(D);
        }
        public IActionResult TestPhoView(int id)
        {
            Photographer p = new Photographer();
            p = context.Photographers.Where(p => p.Ph_Id == id).FirstOrDefault();
            context.Albums.ToList();
            context.Images.ToList();
            context.Reviews.ToList();
            context.Members.ToList();
            context.Users.ToList();
            return View(p);
        }

        [HttpPost]
        [Authorize(Roles = "User")]
        public IActionResult PostReview(int id, Review review)
        {
            Photographer photographer = context.Photographers.Where(p => p.Ph_Id == id).FirstOrDefault();
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
                });
                context.SaveChanges();
                return RedirectToAction("TestPhoView", new { id = photographer.Ph_Id } );
            }
            return View(photographer);
        }

        [HttpPost]
        [Authorize(Roles = "User")]
        public IActionResult PostDesReview(int id , Review review)
        {
            Designer designer = context.Designers.Where(d => d.ID == id).FirstOrDefault();
            var user = User.FindFirst(ClaimTypes.NameIdentifier);
            context.Users.ToList();
            Member member = context.Members.Where(m => m.Users.Id == user.Value).FirstOrDefault();
            if (ModelState.IsValid)
            {
                designer.Reviews.Add(new Review()
                {
                    Quality = review.Quality,
                    DeleverTime = review.DeleverTime,
                    TimeManagement = review.TimeManagement,
                    ReviewMessage = review.ReviewMessage,
                    ReviewDate = DateTime.Now,
                    ReviewedMember = member
                });
                context.SaveChanges();
                return RedirectToAction("TestDesiView", new { id = designer.ID });
            }
            return View(designer);
        }

        [HttpPost]
        [Authorize(Roles = "User")]
        public IActionResult PostHallReview(int id, Review review)
        {
            WeddingHall hall = context.Hotels.Where(d => d.ID == id).FirstOrDefault();
            var user = User.FindFirst(ClaimTypes.NameIdentifier);
            context.Users.ToList();
            Member member = context.Members.Where(m => m.Users.Id == user.Value).FirstOrDefault();
            if (ModelState.IsValid)
            {
                hall.HallsReview.Add(new Review()
                {
                    Quality = review.Quality,
                    DeleverTime = review.DeleverTime,
                    TimeManagement = review.TimeManagement,
                    ReviewMessage = review.ReviewMessage,
                    ReviewDate = DateTime.Now,
                    ReviewedMember = member
                });
                context.SaveChanges();
                return RedirectToAction("TestweddView", new { id = hall.ID });
            }
            return View(hall);
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


        [HttpPost]
        [Authorize(Roles = "User")]
        public IActionResult WeddRequest(int id, WeddingHallsRequest wd)
        {
            WeddingHallsRequest wdr = new WeddingHallsRequest();
            var user = User.FindFirst(ClaimTypes.NameIdentifier);
            WeddingHall w = context.Hotels.Where(p => p.ID == id).FirstOrDefault();
            context.Users.ToList();
            var member = context.Members.Where(m => m.Users.Id == user.Value).FirstOrDefault();
            wdr.RequestHotel = w;
            wdr.Date = wd.Date;
            wdr.RequestUser = member;
            wdr.Message = wd.Message;
            wdr.Status = "Pending";
            context.WeddingHallsRequests.Add(wdr);
            context.SaveChanges();
            return RedirectToAction("TestWeddView", new { id = id });
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet]
        [Route("Home/find/{id}")]
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
        [Route("UpdateRequest")]
        public IActionResult Update(int id,string Inv_Id , string Message , int Quantity , string Date)
        {
            var user = User.FindFirst(ClaimTypes.NameIdentifier);
            var member = context.Members.Where(m => m.Users.Id == user.Value).FirstOrDefault();
            var invitation = context.InvitationCards.Find(int.Parse(Inv_Id));
            Designer d = context.Designers.Where(des => des.ID == id).FirstOrDefault();
            DesignerRequest dr = new DesignerRequest();
            dr.InvitationStyle = invitation;
            dr.Message = Message;
            dr.Quantity = Quantity;
            dr.RequestHotel = d;
            dr.RequestUser = member;
            dr.Date = Date;
            dr.Status = "pending";
            context.DesignerRequests.Add(dr);
            context.SaveChanges();
            return RedirectToAction("TestDesiView", new { id = d.ID });
        }


        [HttpPost]
        public IActionResult Recommendation(float Budget, string date, int InvNumber , string City)
        {
            if(context.Recommendations.ToList().Count != 0)
            {
                foreach (var item in context.Recommendations.ToList())
                {
                    context.Recommendations.Remove(item);
                    context.SaveChanges();
                }
            }
            var newdate = date.Split('-');
            string dateNew = $"{newdate[2]}-{newdate[1]}-{newdate[0]}";
            List<Recommendation> recommendations = new List<Recommendation>();
            List<Photographer> ph = new List<Photographer>();
            List<WeddingHall> wd = new List<WeddingHall>();
            List<Designer> d = new List<Designer>();
            context.InvitationCards.ToList();
            d = context.Designers.ToList();
            wd = context.Hotels.Where(w => w.Address.Contains(City) && w.TestDate.Contains(dateNew)).ToList();
            ph = context.Photographers.Where(p => p.TestDate.Contains(dateNew) && p.Ph_Address.Contains(City)).ToList();
            for (int i = 0; i < wd.Count(); i++)
            {
                for (int j = 0; j < ph.Count(); j++)
                {
                    for (int x = 0; x < d.Count(); x++)
                    {
                        for (int z = 0; z < d[x].Invitations.Count(); z++)
                        {
                            float totalCardPrice = InvNumber * d[x].Invitations[0].Inv_Price;
                            if((wd[i].Hall_Price + ph[j].Ph_Price + totalCardPrice) < Budget)
                            {
                                context.Recommendations.Add(new Recommendation() { RecommendedWeddingHall = wd[i], RecommendedPhotographer = ph[j], RecommendedDesigner = d[x], RecommendedInvitation = d[x].Invitations[z] , Save = Budget - (wd[i].Hall_Price + ph[j].Ph_Price + totalCardPrice) , Date = dateNew , InvQuantity = InvNumber});
                                context.SaveChanges();
                            }
                            break;
                        }
                    }
                }
            }
            return RedirectToAction("LastReco");    
        }

        [HttpPost]
        [Authorize(Roles = "User")]
        public IActionResult AcceptReco(int id)
        {
            var user = User.FindFirst(ClaimTypes.NameIdentifier);
            Member m = context.Members.Where(m => m.Users.Id == user.Value).FirstOrDefault();
            context.Photographers.ToList();
            context.Designers.ToList();
            context.Hotels.ToList();
            context.InvitationCards.ToList();
            Recommendation reco = context.Recommendations.Where(r => r.ID == id).FirstOrDefault();
            context.WeddingHallsRequests.Add(new WeddingHallsRequest() { Date = reco.Date, Message = "Recomendation", RequestHotel = reco.RecommendedWeddingHall, RequestUser = m, Status = "Pending" });
            context.PhotographerRequests.Add(new PhotographerRequest() { Date = reco.Date, Message = "Recommendation", RequestPhotographer = reco.RecommendedPhotographer, RequestUser = m, Status = "Prnding" });
            context.DesignerRequests.Add(new DesignerRequest() { Date = reco.Date, Message = "Recommendation", RequestHotel = reco.RecommendedDesigner, InvitationStyle = reco.RecommendedInvitation, Quantity = reco.InvQuantity, RequestUser = m, Status = "Pending" });
            context.SaveChanges();
            return RedirectToAction("TestView");
        }
    }


}

