using Backend_Project_Allup.DAL;
using Backend_Project_Allup.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin")]
    public class SalesController : Controller
    {
        private readonly Context _context;
        private readonly UserManager<AppUser> _userManager;

        public SalesController(Context context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {

            List<Sales> sales = _context.Sales
                .Include(x => x.AppUser)
                .Include(p => p.SalesProducts)
                .ThenInclude(p => p.Product).ToList();
            return View(sales);
        }
        public IActionResult Detail(int id)
        {

            List<Sales> sales = _context.Sales
                .Include(x => x.AppUser)
                .Include(p => p.SalesProducts)
                .ThenInclude(p => p.Product).ToList();
            return View(sales);
        }
    }
}
