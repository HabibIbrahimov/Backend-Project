using Backend_Project_Allup.DAL;
using Backend_Project_Allup.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class ContactController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly Context _context;

        public ContactController(Context context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
    
        public ActionResult Index()
        {
            List<Contact> contacts = _context.Contacts.ToList();
            return View(contacts);

        }

       
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            Contact dbContact = await _context.Contacts.FindAsync(id);
            if (dbContact == null) return NotFound();
            return View(dbContact);
        }

       
        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Contact contact)
        {
            Contact newContact = new Contact
            {
                Text = contact.Text,
                Address = contact.Address,
                MapUrl = contact.MapUrl,
                Email = contact.Email,
                SupportEmail = contact.SupportEmail,
                MobileNum = contact.MobileNum,
                HotlineNum = contact.HotlineNum,
                
            };

            await _context.AddAsync(newContact);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

       
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Contact dbContact = await _context.Contacts.FindAsync(id);
            if (dbContact == null) return NotFound();
            return View(dbContact);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Contact contact)
        {
            Contact dbContact = await _context.Contacts.FindAsync(id);
            dbContact.HotlineNum = contact.HotlineNum;
            dbContact.MapUrl = contact.MapUrl;
            dbContact.MobileNum = contact.MobileNum;
            
            dbContact.SupportEmail = contact.SupportEmail;
            dbContact.Email = contact.Email;
            dbContact.Text = contact.Text;
            dbContact.Address = contact.Address;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }

       
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Contact dbContact = await _context.Contacts.FindAsync(id);
            if (dbContact == null) return NotFound();
            return View(dbContact);

        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            Contact dbContact = await _context.Contacts.FindAsync(id);
            _context.Contacts.Remove(dbContact);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
