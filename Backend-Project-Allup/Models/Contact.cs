using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Address { get; set; }
        public string MapUrl { get; set; }
        public string MobileNum { get; set; }
        public string HotlineNum { get; set; }
        public string Email { get; set; }
        public string SupportEmail { get; set; }
    }
}
