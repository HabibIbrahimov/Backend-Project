using Backend_Project_Allup.DAL;
using Backend_Project_Allup.Models;
using Backend_Project_Allup.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Backend_Project_Allup.Controllers
{
   
    public class ContactController : Controller
    {
        private readonly Context _context;
        private readonly UserManager<AppUser> _userManager;

        public ContactController(Context context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            Contact contact = _context.Contacts.FirstOrDefault();
            ContactVM contactVM = new ContactVM();
            if (User.Identity.IsAuthenticated)
            {
                contactVM.User = await _userManager.FindByIdAsync(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

            }
            contactVM.Contact = contact;
            return View(contactVM);
        }

        [HttpPost]
        public async Task<IActionResult> Message([FromForm] Message message)
        {
            if (User.Identity.IsAuthenticated)
            {
                Message newMessage = new Message();

                newMessage.UserId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                newMessage.Title = message.Title;
                newMessage.Text = message.Text;
                await _context.Messages.AddAsync(newMessage);

                _context.SaveChanges();

            }

            else
            {
                return RedirectToAction("LogIn", "Account");
            }



            return Ok(new { Message = "Success your send message" });
        }

    }

}
