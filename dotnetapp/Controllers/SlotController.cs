
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// using gym.Data;
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

}
}