using Backend_Project_Allup.DAL;
using Backend_Project_Allup.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private readonly Context _context;
        public FooterViewComponent(Context context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio bio = _context.Bios.FirstOrDefault();
            return View(await Task.FromResult(bio));

        }
    }
}
