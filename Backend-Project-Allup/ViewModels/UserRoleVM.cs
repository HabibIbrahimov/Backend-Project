using Backend_Project_Allup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.ViewModels
{
    public class UserRoleVM
    {
        public AppUser AppUser;
        public IList<string> Roles;
    }
}
