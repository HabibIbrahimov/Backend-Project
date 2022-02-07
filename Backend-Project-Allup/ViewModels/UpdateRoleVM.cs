﻿using Backend_Project_Allup.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.ViewModels
{
    public class UpdateRoleVM
    {
        public IList<IdentityRole> Roles { get; set; }
        public IList<string> UserRoles { get; set; }
        public string Userid { get; set; }
        public AppUser User { get; set; }
    }
}
