﻿using System;
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
    public class HallsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HallsController(ApplicationDbContext context)
        {
            _context = context;
        }
     
        // GET: Halls
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hotels.ToListAsync());
        }

        // GET: Halls/Details/5

        public async Task<IActionResult> Widgets()
        {
            return View(await _context.Admins.ToListAsync());
        }
        public async Task<IActionResult>Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weddingHall = await _context.Hotels
                .FirstOrDefaultAsync(m => m.ID == id);
            if (weddingHall == null)
            {
                return NotFound();
            }

            return View(weddingHall);
        }

        // GET: Halls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Halls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,PhoneNumber,Hall_ImgPath,Address,Hall_Price,Offers,Capacity,OtherServices,HallType")] WeddingHall weddingHall)
        {
            if (ModelState.IsValid)
            {
                _context.Add(weddingHall);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(weddingHall);
        }

        // GET: Halls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weddingHall = await _context.Hotels.FindAsync(id);
            if (weddingHall == null)
            {
                return NotFound();
            }
            return View(weddingHall);
        }

        // POST: Halls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,PhoneNumber,Hall_ImgPath,Address,Hall_Price,Offers,Capacity,OtherServices,HallType")] WeddingHall weddingHall)
        {
            if (id != weddingHall.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(weddingHall);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WeddingHallExists(weddingHall.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(weddingHall);
        }

        // GET: Halls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weddingHall = await _context.Hotels
                .FirstOrDefaultAsync(m => m.ID == id);
            if (weddingHall == null)
            {
                return NotFound();
            }

            return View(weddingHall);
        }

        // POST: Halls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var weddingHall = await _context.Hotels.FindAsync(id);
            _context.Hotels.Remove(weddingHall);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WeddingHallExists(int id)
        {
            return _context.Hotels.Any(e => e.ID == id);
        }


    }
}

//        // GET: Admins
//        public async Task<IActionResult> Index()
//        {


//            Photographer photo = new Photographer();
//            ViewBag.PhotographersCount = _context.Photographers.Count(x=>x.Ph_Requests.Count!=0);
//            return View(await _context.Admins.ToListAsync());
//        }
//        public async Task<IActionResult>Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var admin = await _context.Admins
//                .FirstOrDefaultAsync(m => m.ID == id);
//            if (admin == null)
//            {
//                return NotFound();
//            }

//            return View(admin);
//        }

//        // GET: Admins/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: Admins/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("ID,Name")] Admin admin)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(admin);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(admin);
//        }

//        // GET: Admins/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var admin = await _context.Admins.FindAsync(id);
//            if (admin == null)
//            {
//                return NotFound();
//            }
//            return View(admin);
//        }

//        // POST: Admins/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("ID,Name")] Admin admin)
//        {
//            if (id != admin.ID)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(admin);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!AdminExists(admin.ID))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(admin);
//        }

//        // GET: Admins/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var admin = await _context.Admins
//                .FirstOrDefaultAsync(m => m.ID == id);
//            if (admin == null)
//            {
//                return NotFound();
//            }

//            return View(admin);
//        }

//        // POST: Admins/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var admin = await _context.Admins.FindAsync(id);
//            _context.Admins.Remove(admin);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool AdminExists(int id)
//        {
//            return _context.Admins.Any(e => e.ID == id);
//        }







//    }
//}