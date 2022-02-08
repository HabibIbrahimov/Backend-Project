using Backend_Project_Allup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.ViewModels
{
    public class ContactVM
    {
        public Contact Contact { get; set; }
        public AppUser User { get; set; }
        public Message Message { get; set; }
    }
}
