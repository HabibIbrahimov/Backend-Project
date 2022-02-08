using Backend_Project_Allup.DAL;
using Backend_Project_Allup.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.ViewComponents
{
    public class SubscribeViewComponent: ViewComponent
    {
        private readonly Context _context;

        public SubscribeViewComponent(Context context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Subscribe subscribe = _context.Subscribes.FirstOrDefault();
            return View(await Task.FromResult(subscribe));
        }
    }
}
