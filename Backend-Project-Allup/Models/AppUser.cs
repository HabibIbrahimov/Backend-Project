using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.Models
{
    public class AppUser:IdentityUser
    {
        [Required, StringLength(maximumLength: 50)]
        public string FullName { get; set; }
    }
}
