using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            //write functionality here...
            return null;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Slot slot)
        {
            //write functionality here with SlotBookingException "Slot capacity should not exceed 4."
            return null;        
        }
    }
}