using Backend_Project_Allup.DAL;
using Backend_Project_Allup.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    public class MessageController : Controller
    {
        private readonly Context _context;
        private readonly UserManager<AppUser> _userManager;
        public MessageController(Context context, UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _context = context;

        }
        public ActionResult Index()
        {
            List<Message> messages = _context.Messages.Include(u => u.User).ToList();

            return View(messages);
        }

        public async Task<ActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            List<Message> messages = _context.Messages.Include(u => u.User).ToList();
            var singlemessages = messages.Find(x => x.Id == id);
            if (singlemessages == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(singlemessages.UserId);
            singlemessages.User = user;
            return View(singlemessages);
        }

       

        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            List<Message> messages = _context.Messages.Include(u => u.User).ToList();
            var singlemessages = messages.Find(x => x.Id == id);
            if (singlemessages == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(singlemessages.UserId);
            singlemessages.User = user;
            return View(singlemessages);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, Message message)
        {
            _context.Messages.Remove(message);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
