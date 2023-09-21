using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// using gym.Data;
using dotnetapp.Exceptions; 

using dotnetapp.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetapp.Controllers
{



public class SlotController : Controller
{
    private readonly ApplicationDbContext _context;

    public SlotController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var slots = _context.Slots.ToList();
        return View(slots);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Slot slot)
    {
        if (slot.Capacity > 4)
        {
            throw new SlotBookingException("Slot capacity should not exceed 4.");
        }

        _context.Slots.Add(slot);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}
}