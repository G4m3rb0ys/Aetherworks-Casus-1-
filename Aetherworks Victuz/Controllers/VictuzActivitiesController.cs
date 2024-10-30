﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Aetherworks_Victuz.Data;
using Aetherworks_Victuz.Models;
using static Aetherworks_Victuz.Models.VictuzActivity;

namespace Aetherworks_Victuz.Controllers
{
    public class VictuzActivitiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VictuzActivitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: VictuzActivities
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.victuzActivities.Include(v => v.Host);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: VictuzActivities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var victuzActivity = await _context.victuzActivities
                .Include(v => v.Host)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (victuzActivity == null)
            {
                return NotFound();
            }

            return View(victuzActivity);
        }

        private string GetDisplayNameForCategory(ActivityCategories category)
        {
            return category switch
            {
                ActivityCategories.Free => "Free for Everyone",
                ActivityCategories.MemFree => "Free for Members Only",
                ActivityCategories.PayAll => "Paid for All",
                ActivityCategories.MemOnlyFree => "Members Only - Free",
                ActivityCategories.MemOnlyPay => "Members Only - Paid",
                _ => category.ToString()
            };
        }
        // GET: VictuzActivities/Create
        public IActionResult Create()
        {
            ViewData["HostId"] = new SelectList(_context.user, "Id", "Id");
            var enumCategories = Enum.GetValues(typeof(VictuzActivity.ActivityCategories))
                .Cast<VictuzActivity.ActivityCategories>()
                .ToDictionary(
                    category => category,
                    category => GetDisplayNameForCategory(category) // Mapping each enum to a custom display name
                );

            ViewData["Category"] = new SelectList(enumCategories, "Key", "Value");
            return View();
        }

        // POST: VictuzActivities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,HostId,Location,Price,MemberPrice,ActivityTime,ParticipantLimit,Categories")] VictuzActivity victuzActivity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(victuzActivity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HostId"] = new SelectList(_context.user, "Id", "Id", victuzActivity.HostId);
            return View(victuzActivity);
        }

        // GET: VictuzActivities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var victuzActivity = await _context.victuzActivities.FindAsync(id);
            if (victuzActivity == null)
            {
                return NotFound();
            }
            ViewData["HostId"] = new SelectList(_context.user, "Id", "Id", victuzActivity.HostId);
            return View(victuzActivity);
        }

        // POST: VictuzActivities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,HostId,Location,Price,MemberPrice,ActivityTime,ParticipantLimit,Categories")] VictuzActivity victuzActivity)
        {
            if (id != victuzActivity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(victuzActivity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VictuzActivityExists(victuzActivity.Id))
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
            ViewData["HostId"] = new SelectList(_context.user, "Id", "Id", victuzActivity.HostId);
            return View(victuzActivity);
        }

        // GET: VictuzActivities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var victuzActivity = await _context.victuzActivities
                .Include(v => v.Host)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (victuzActivity == null)
            {
                return NotFound();
            }

            return View(victuzActivity);
        }

        // POST: VictuzActivities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var victuzActivity = await _context.victuzActivities.FindAsync(id);
            if (victuzActivity != null)
            {
                _context.victuzActivities.Remove(victuzActivity);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VictuzActivityExists(int id)
        {
            return _context.victuzActivities.Any(e => e.Id == id);
        }
    }
}
