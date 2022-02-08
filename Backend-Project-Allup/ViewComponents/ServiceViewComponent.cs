using Backend_Project_Allup.DAL;
using Backend_Project_Allup.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.ViewComponents
{
    public class ServiceViewComponent: ViewComponent
    {
        private readonly Context _context;
        public ServiceViewComponent(Context context)
        {
            _context = context;
           
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            List<Service> services = _context.Services.ToList();
            return View(await Task.FromResult(services));

        }
    }
}
