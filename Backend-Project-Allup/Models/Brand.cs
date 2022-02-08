using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.Models
{
    public class Brand
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "dont empty")]
        public string Name { get; set; }
        public List<CategoryBrand> CategoryBrand { get; set; }

    }
}
